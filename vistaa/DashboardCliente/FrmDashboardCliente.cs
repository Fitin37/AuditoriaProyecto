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

namespace vistaa.DashboardCliente
{
    public partial class FrmDashboardCliente : Form
    {
        private Form FormularioActivo = null;

        private void AbrirFormularioenPanel(Form Formulariobebe)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = Formulariobebe;

            Formulariobebe.TopLevel = false;
            Formulariobebe.FormBorderStyle = FormBorderStyle.None;
            Formulariobebe.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(Formulariobebe);
            panel1.BringToFront();

            Formulariobebe.BringToFront();
            Formulariobebe.Show();
        }
        public FrmDashboardCliente()
        {
            InitializeComponent();
        }

        private void btnVerCitas_Click(object sender, EventArgs e) { AbrirFormularioenPanel(new FrmCitas(true)); }
        private void btnVerPagos_Click(object sender, EventArgs e) { AbrirFormularioenPanel(new FrmPagos(true)); }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmDashboardCliente_Load(object sender, EventArgs e)
        {

        }

        private void pnlSalida_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void btnMispropi_Click(object sender, EventArgs e)
        {
            AbrirFormularioenPanel(new FrmPropiedades(true));
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirFormularioenPanel(new FrmVentas(true));
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            AbrirFormularioenPanel(new FrmAlquileres(true));
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
