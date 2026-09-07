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

namespace vistaa.DashboardAgente
{
    public partial class FrmDashboardAgente : Form
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
        public FrmDashboardAgente()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e) { AbrirFormularioenPanel(new FrmUsuarios()); }
        private void btnAlquileres_Click(object sender, EventArgs e) { AbrirFormularioenPanel(new FrmAlquileres()); }
        private void btnPagos_Click(object sender, EventArgs e) { AbrirFormularioenPanel(new FrmPagos()); }
        private void btnVerCitas_Click(object sender, EventArgs e) { AbrirFormularioenPanel(new FrmCitas()); }
        private void btnMantenimientos_Click(object sender, EventArgs e) { AbrirFormularioenPanel(new FrmMantenimientos()); }


        private void btnMispropi_Click(object sender, EventArgs e)
        {
            AbrirFormularioenPanel(new FrmPropiedades());
        }

        private void btnCitas_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioenPanel(new FrmClientes());
        }

        private void btnContratos_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioenPanel(new FrmAgentes());
        }

        private void btnPerfil_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioenPanel(new FrmVentas());
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

        private void FrmDashboardAgente_Load(object sender, EventArgs e)
        {

        }
    }
}
