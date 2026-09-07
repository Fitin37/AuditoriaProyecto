using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modeloss.Conexion_DB;
using modeloss.Entidades;

namespace vistaa.GestioneNova
{
    public partial class FrmClientes : Form
    {
        public FrmClientes(int idCliente) : this()
        {
        }

        public FrmClientes()
        {
            InitializeComponent();
            this.Load += FrmPropiedades_Load;
        }

        private void RefrescarGrid()
        {

            dgvCliente.DataSource = Cliente.Listar();
        }

        private void FrmPropiedades_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarGrid();
                btnNuevoCliente.Visible = modeloss.Sesion.TienePermiso("Clientes", "Crear");
                btnEditarCliente.Visible = modeloss.Sesion.TienePermiso("Clientes", "Editar");
                btnEliminarCliente.Visible = modeloss.Sesion.TienePermiso("Clientes", "Eliminar");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El formulario abrió correctamente, pero no se pudo conectar con la base de datos.\n\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmNuevoRegistro formularioCliente = new FrmNuevoRegistro(TipoRegistro.Cliente);
            if (formularioCliente.ShowDialog() == DialogResult.OK)
            {
                RefrescarGrid();
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {

                int idCliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);


                FrmNuevoRegistro formularioCliente = new FrmNuevoRegistro(TipoRegistro.Cliente, idCliente);
                if (formularioCliente.ShowDialog() == DialogResult.OK)
                {
                    RefrescarGrid();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.");
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    int idCliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);

                    try
                    {
                        Cliente.Eliminar(idCliente);
                        RefrescarGrid();
                        MessageBox.Show("Cliente y registros relacionados eliminados correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar el cliente.\n\n" + ex.Message,
                            "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            RefrescarGrid();
            MessageBox.Show("Datos actualizados.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCliente.DataSource = Cliente.Listar(txtBuscarCliente.Text.Trim());
        }
    }
}
