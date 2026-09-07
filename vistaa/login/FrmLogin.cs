using System;
using System.Data.SqlClient;
using System.Windows.Forms;
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
            txtUsuario.MaxLength=50; txtContra.MaxLength=50; txtContra.UseSystemPasswordChar=true;
            txtUsuario.TabIndex=0; txtContra.TabIndex=1; btnIngresar.TabIndex=2;
            txtUsuario.KeyDown+=BloquearPortapapeles; txtContra.KeyDown+=BloquearPortapapeles;
        }

        private void BloquearPortapapeles(object sender,KeyEventArgs e)
        { if(e.Control&&(e.KeyCode==Keys.C||e.KeyCode==Keys.V||e.KeyCode==Keys.X)){e.SuppressKeyPress=true;MessageBox.Show("Debe digitar sus credenciales.");} }

        private void btnIngresar_Click(object sender,EventArgs e)
        {
            string usuario=txtUsuario.Text.Trim(), contra=txtContra.Text;
            if(usuario==""||contra==""){MessageBox.Show("Digite el usuario y la contraseña.");return;}
            try
            {
                string hash=null,rol=null; int idUsuario = -1;
                using(SqlConnection conexion=new SqlConnection(modeloss.Conexion_DB.Conexion_DB.CadenaConexion))
                using(SqlCommand comando=new SqlCommand("SELECT u.IdUsuario, u.Contrasena, r.Nombre FROM Usuarios u INNER JOIN Roles r ON u.IdRol=r.IdRol INNER JOIN Estados e ON u.IdEstado=e.IdEstado WHERE u.Usuario=@usuario AND e.Nombre='Activo'",conexion))
                {
                    comando.Parameters.AddWithValue("@usuario",usuario); conexion.Open();
                    using(SqlDataReader lector=comando.ExecuteReader())
                    {
                        if(lector.Read())
                        {
                            idUsuario = lector.GetInt32(0);
                            hash = lector.IsDBNull(1) ? null : lector.GetString(1);
                            rol = lector.IsDBNull(2) ? null : lector.GetString(2);
                        }
                    }
                }
                if(hash==null||!global::BCrypt.Net.BCrypt.Verify(contra,hash))
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                // Cargar sesión desde la base usando el id de usuario
                bool sesionOk = modeloss.Sesion.CargarDesdeBase(idUsuario);
                if(!sesionOk)
                {
                    MessageBox.Show("No se pudo asignar rol al usuario. Contacte al administrador.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                // Obtener rol real desde Sesion para decidir dashboard
                rol = modeloss.Sesion.Rol;
                Form dashboard=rol=="Administrador"?(Form)new FrmDashboardAdministrador():rol=="Agente"?new FrmDashboardAgente():(Form)new FrmDashboardCliente();
                dashboard.FormClosed+=(s,args)=>
                {
                    txtContra.Clear();
                    Show();
                    Activate();
                };
                dashboard.Show();
                Hide();
            }
            catch(Exception ex){MessageBox.Show("No se pudo iniciar sesión.\n\n"+ex.Message,"Error de conexión",MessageBoxButtons.OK,MessageBoxIcon.Error);}
        }
    }
}
