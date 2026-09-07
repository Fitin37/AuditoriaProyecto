using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using modeloss.Conexion_DB;
using modeloss.Entidades;

namespace vistaa.GestioneNova
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios(int idUsuario) : this() { }
        public FrmUsuarios() { InitializeComponent(); this.Load += FrmUsuarios_Load; }

        private void RefrescarGrid()
        {
            dgvUsuarios.DataSource = Usuario.Listar();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            try { RefrescarGrid(); }
            catch (Exception ex) { MessageBox.Show("No se pudo conectar con la base de datos.\n\n" + ex.Message); }
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FrmNuevoRegistro formularioUsuario = new FrmNuevoRegistro(TipoRegistro.Usuario);
            if (formularioUsuario.ShowDialog() == DialogResult.OK) RefrescarGrid();
        }

        private void btnEditarUsuarios_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
                FrmNuevoRegistro formularioUsuario = new FrmNuevoRegistro(TipoRegistro.Usuario, idUsuario);
                if (formularioUsuario.ShowDialog() == DialogResult.OK) RefrescarGrid();
            }
            else MessageBox.Show("Por favor, seleccione una fila para editar.");
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
                    try
                    {
                        Usuario.Eliminar(idUsuario);
                        RefrescarGrid();
                        MessageBox.Show("Usuario y registros relacionados eliminados correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar el usuario.\n\n" + ex.Message,
                            "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Seleccione una fila para eliminar.");
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e) { RefrescarGrid(); MessageBox.Show("Datos actualizados."); }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = Usuario.Listar(txtBuscarUsuario.Text.Trim());
        }
    }
}
