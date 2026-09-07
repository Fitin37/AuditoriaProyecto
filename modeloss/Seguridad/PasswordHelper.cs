using System;
using System.Security.Cryptography;
using System.Text;

namespace modeloss.Seguridad
{
    public static class PasswordHelper
    {
        // PBKDF2 parameters
        private const int SaltSize = 16; // 128 bit
        private const int HashSize = 32; // 256 bit
        private const int Iterations = 100000;

        // Formato: pbkdf2$iterations$base64salt$base64hash
        public static string HashPassword(string password)
        {
            if (password == null) throw new ArgumentNullException(nameof(password));
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[SaltSize];
                rng.GetBytes(salt);
                using (var derive = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
                {
                    byte[] hash = derive.GetBytes(HashSize);
                    return $"pbkdf2${Iterations}${Convert.ToBase64String(salt)}${Convert.ToBase64String(hash)}";
                }
            }
        }

        public static bool VerifyPassword(string stored, string provided)
        {
            if (stored == null) return false;
            if (provided == null) return false;

            // bcrypt hashes start with $2
            if (stored.StartsWith("$2"))
            {
                try
                {
                    Type t = Type.GetType("BCrypt.Net.BCrypt, BCrypt.Net-Next") ?? Type.GetType("BCrypt.Net.BCrypt");
                    if (t != null)
                    {
                        var mi = t.GetMethod("Verify", new Type[] { typeof(string), typeof(string) });
                        if (mi != null)
                        {
                            object ok = mi.Invoke(null, new object[] { provided, stored });
                            if (ok is bool) return (bool)ok;
                        }
                    }
                }
                catch
                {
                    // ignore and fallback
                }
                return false;
            }

            // pbkdf2 format
            if (stored.StartsWith("pbkdf2$"))
            {
                try
                {
                    string[] parts = stored.Split('$');
                    if (parts.Length != 4) return false;
                    int iterations = int.Parse(parts[1]);
                    byte[] salt = Convert.FromBase64String(parts[2]);
                    byte[] hash = Convert.FromBase64String(parts[3]);
                    using (var derive = new Rfc2898DeriveBytes(provided, salt, iterations, HashAlgorithmName.SHA256))
                    {
                        byte[] test = derive.GetBytes(hash.Length);
                        return FixedTimeEquals(hash, test);
                    }
                }
                catch
                {
                    return false;
                }
            }

            // fallback plain text (not recommended)
            return string.Equals(stored, provided);
        }

        private static bool FixedTimeEquals(byte[] a, byte[] b)
        {
            if (a == null || b == null || a.Length != b.Length) return false;
            int diff = 0;
            for (int i = 0; i < a.Length; i++) diff |= a[i] ^ b[i];
            return diff == 0;
        }
    }
}
