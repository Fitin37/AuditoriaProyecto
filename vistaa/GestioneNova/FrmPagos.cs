using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using modeloss.Conexion_DB;
using modeloss.Entidades;

namespace vistaa.GestioneNova
{
    public partial class FrmPagos : Form
    {
        public FrmPagos(int idPago) : this() { }
        public FrmPagos(bool soloLectura) : this() { btnNuevoPago.Visible=!soloLectura; btnEditarPagos.Visible=!soloLectura; btnEliminarPago.Visible=!soloLectura; }

        public FrmPagos()
        {
            InitializeComponent();
            this.Load += FrmPagos_Load;
        }

        private void RefrescarGrid()
        {
            dgvPagos.DataSource = Pago.Listar();
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            try { RefrescarGrid(); }
            catch (Exception ex) { MessageBox.Show("No se pudo conectar con la base de datos.\n\n" + ex.Message); }
            // Ajustar botones según permisos
            btnNuevoPago.Visible = modeloss.Sesion.TienePermiso("Pagos", "Crear");
            btnEditarPagos.Visible = modeloss.Sesion.TienePermiso("Pagos", "Editar");
            btnEliminarPago.Visible = modeloss.Sesion.TienePermiso("Pagos", "Eliminar");
        }

        private void btnNuevoPago_Click(object sender, EventArgs e)
        {
            FrmNuevoRegistro formularioPago = new FrmNuevoRegistro(TipoRegistro.Pago);
            if (formularioPago.ShowDialog() == DialogResult.OK) RefrescarGrid();
        }

        private void btnEditarPagos_Click(object sender, EventArgs e)
        {
            if (dgvPagos.SelectedRows.Count > 0)
            {
                int idPago = Convert.ToInt32(dgvPagos.CurrentRow.Cells[0].Value);
                FrmNuevoRegistro formularioPago = new FrmNuevoRegistro(TipoRegistro.Pago, idPago);
                if (formularioPago.ShowDialog() == DialogResult.OK) RefrescarGrid();
            }
            else MessageBox.Show("Por favor, seleccione una fila para editar.");
        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            if (dgvPagos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar este pago?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int idPago = Convert.ToInt32(dgvPagos.CurrentRow.Cells[0].Value);
                    try
                    {
                        Pago.Eliminar(idPago);
                        RefrescarGrid();
                        MessageBox.Show("Registro eliminado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar el pago.\n\n" + ex.Message,
                            "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Seleccione una fila para eliminar.");
        }

        private void btnActualizarPago_Click(object sender, EventArgs e) { RefrescarGrid(); MessageBox.Show("Datos actualizados."); }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPagos.DataSource = Pago.Listar(txtBuscarPago.Text.Trim());
        }
    }
}
