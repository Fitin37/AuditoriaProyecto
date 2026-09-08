using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using modeloss;
using modeloss.Conexion_DB;
using vistaa.DashboardAdmin;
using vistaa.DashboardAgente;
using vistaa.DashboardCliente;

namespace vistaa.login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtUsuario.MaxLength = 50;
            txtContra.MaxLength = 50;
            txtContra.UseSystemPasswordChar = true;
            txtUsuario.TabIndex = 0;
            txtContra.TabIndex = 1;
            btnIngresar.TabIndex = 2;
            txtUsuario.KeyDown += BloquearPortapapeles;
            txtContra.KeyDown += BloquearPortapapeles;
        }

        private void BloquearPortapapeles(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true;
                MessageBox.Show("Debe digitar sus credenciales.");
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contra = txtContra.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contra))
            {
                MessageBox.Show("Digite el usuario y la contraseña.");
                return;
            }

            try
            {
                string hash = null;
                int idUsuario = -1;

                using (SqlConnection conexion = new SqlConnection(modeloss.Conexion_DB.Conexion_DB.CadenaConexion))
                using (SqlCommand comando = new SqlCommand(
                    "SELECT u.IdUsuario, u.Contrasena FROM Usuarios u INNER JOIN Estados e ON u.IdEstado = e.IdEstado WHERE u.Usuario = @usuario AND e.Nombre = 'Activo'", conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    conexion.Open();

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            idUsuario = lector.GetInt32(0);
                            hash = lector.IsDBNull(1) ? null : lector.GetString(1);
                        }
                    }
                }

                if (hash == null || !global::BCrypt.Net.BCrypt.Verify(contra, hash))
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Carga dinámica de Rol, IdCliente e IdAgente
                if (!Sesion.CargarDesdeBase(idUsuario))
                {
                    MessageBox.Show("No se pudo cargar los permisos del usuario. Contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Determinación dinámica de la pantalla según el perfil
                Form dashboard;
                if (Sesion.Rol.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
                {
                    dashboard = new FrmDashboardAdministrador();
                }
                else if (Sesion.EsAgente || Sesion.Rol.Equals("Agente", StringComparison.OrdinalIgnoreCase))
                {
                    dashboard = new FrmDashboardAgente();
                }
                else
                {
                    dashboard = new FrmDashboardCliente();
                }

                dashboard.FormClosed += (s, args) =>
                {
                    txtContra.Clear();
                    Show();
                    Activate();
                };

                dashboard.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo iniciar sesión.\n\n" + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}