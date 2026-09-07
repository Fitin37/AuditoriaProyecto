using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using modeloss.Conexion_DB;
using modeloss.Entidades;

namespace vistaa.GestioneNova
{
    public partial class FrmMantenimientos : Form
    {
        public FrmMantenimientos(int idMantenimiento) : this() { }
        public FrmMantenimientos() { InitializeComponent(); this.Load += FrmMantenimientos_Load; }

        private void RefrescarGrid()
        {
            dgvMantenimientos.DataSource = Mantenimiento.Listar();
        }

        private void FrmMantenimientos_Load(object sender, EventArgs e)
        {
            try { RefrescarGrid(); }
            catch (Exception ex) { MessageBox.Show("No se pudo conectar con la base de datos.\n\n" + ex.Message); }
            btnNuevoMantenimiento.Visible = modeloss.Sesion.TienePermiso("Mantenimientos", "Crear");
            btnEditarMantenimientos.Visible = modeloss.Sesion.TienePermiso("Mantenimientos", "Editar");
            btnEliminarMantenimiento.Visible = modeloss.Sesion.TienePermiso("Mantenimientos", "Eliminar");
        }

        private void btnNuevoMantenimiento_Click(object sender, EventArgs e)
        {
            FrmNuevoRegistro formularioMantenimiento = new FrmNuevoRegistro(TipoRegistro.Mantenimiento);
            if (formularioMantenimiento.ShowDialog() == DialogResult.OK) RefrescarGrid();
        }

        private void btnEditarMantenimientos_Click(object sender, EventArgs e)
        {
            if (dgvMantenimientos.SelectedRows.Count > 0)
            {
                int idMantenimiento = Convert.ToInt32(dgvMantenimientos.CurrentRow.Cells[0].Value);
                FrmNuevoRegistro formularioMantenimiento = new FrmNuevoRegistro(TipoRegistro.Mantenimiento, idMantenimiento);
                if (formularioMantenimiento.ShowDialog() == DialogResult.OK) RefrescarGrid();
            }
            else MessageBox.Show("Por favor, seleccione una fila para editar.");
        }

        private void btnEliminarMantenimiento_Click(object sender, EventArgs e)
        {
            if (dgvMantenimientos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar este mantenimiento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int idMantenimiento = Convert.ToInt32(dgvMantenimientos.CurrentRow.Cells[0].Value);
                    try
                    {
                        Mantenimiento.Eliminar(idMantenimiento);
                        RefrescarGrid();
                        MessageBox.Show("Registro eliminado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar el mantenimiento.\n\n" + ex.Message,
                            "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Seleccione una fila para eliminar.");
        }

        private void btnActualizarMantenimiento_Click(object sender, EventArgs e) { RefrescarGrid(); MessageBox.Show("Datos actualizados."); }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvMantenimientos.DataSource = Mantenimiento.Listar(txtBuscarMantenimiento.Text.Trim());
        }
    }
}
