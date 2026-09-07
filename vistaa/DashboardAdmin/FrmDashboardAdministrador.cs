using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vistaa.GestioneNova;
using vistaa.login;

namespace vistaa.DashboardAdmin
{
    public partial class FrmDashboardAdministrador : Form
    {
        private Form FormularioActivo=null;

        private void AbrirFormularioenPanel(Form Formulariobebe)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo=Formulariobebe;

           Formulariobebe.TopLevel = false;
            Formulariobebe.FormBorderStyle=FormBorderStyle.None;
            Formulariobebe.Dock= DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(Formulariobebe);
            panel1.BringToFront();

            Formulariobebe.BringToFront();
            Formulariobebe.Show();
        }
        public FrmDashboardAdministrador()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e) { AbrirFormularioenPanel(new FrmUsuarios()); }
        private void btnPagos_Click(object sender, EventArgs e) { AbrirFormularioenPanel(new FrmPagos()); }
        private void btnVerCitas_Click(object sender, EventArgs e) { AbrirFormularioenPanel(new FrmCitas()); }
        private void btnMantenimientos_Click(object sender, EventArgs e) { AbrirFormularioenPanel(new FrmMantenimientos()); }

        private void FrmDashboardAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSalida_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormularioenPanel(new FrmAlquileres());
        }

        private void btnsalida_Click(object sender, EventArgs e)
        {

        }

        private void pnlConsulta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormularioenPanel(new FrmVentas());
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            AbrirFormularioenPanel(new FrmAgentes());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirFormularioenPanel(new FrmClientes());
        }

        private void btnMispropi_Click(object sender, EventArgs e)
        {
            AbrirFormularioenPanel(new FrmPropiedades());
        }

        private void btnConsultaGeneral_Click(object sender, EventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void pnlIcono_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Deseas cerrar sesion?",
                "Cerrar Sesion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
