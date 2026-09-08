using System;
using System.Data;
using System.Windows.Forms;
using modeloss.Entidades;

namespace vistaa.GestioneNova
{
    public partial class FrmCitas : Form
    {
        public FrmCitas(int idCita) : this() { }

        public FrmCitas(bool soloLectura) : this()
        {
            btnNuevoCita.Visible = !soloLectura;
            btnEditarCitas.Visible = !soloLectura;
            btnEliminarCita.Visible = !soloLectura;
        }

        public FrmCitas()
        {
            InitializeComponent();
            this.Load += FrmCitas_Load;
        }

        private void RefrescarGrid()
        {
            dgvCitas.DataSource = Cita.Listar();
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoCita_Click(object sender, EventArgs e)
        {
            FrmNuevoRegistro formularioCita = new FrmNuevoRegistro(TipoRegistro.Cita);
            if (formularioCita.ShowDialog() == DialogResult.OK) RefrescarGrid();
        }

        private void btnEditarCitas_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count > 0)
            {
                int idCita = Convert.ToInt32(dgvCitas.CurrentRow.Cells[0].Value);
                FrmNuevoRegistro formularioCita = new FrmNuevoRegistro(TipoRegistro.Cita, idCita);
                if (formularioCita.ShowDialog() == DialogResult.OK) RefrescarGrid();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar esta cita?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int idCita = Convert.ToInt32(dgvCitas.CurrentRow.Cells[0].Value);
                    try
                    {
                        Cita.Eliminar(idCita);
                        RefrescarGrid();
                        MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar la cita.\n\n" + ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizarCita_Click(object sender, EventArgs e)
        {
            RefrescarGrid();
            MessageBox.Show("Datos actualizados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCitas.DataSource = Cita.Listar(txtBuscarCita.Text.Trim());
        }
    }
}