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
    public partial class FrmVentas : Form
    {
        public FrmVentas(int idVenta) : this()
        {
        }
        public FrmVentas(bool soloLectura) : this() { btnNuevoVenta.Visible=!soloLectura; btnEditarVenta.Visible=!soloLectura; btnEliminarVenta.Visible=!soloLectura; }

        public FrmVentas()
        {
            InitializeComponent();
            this.Load += FrmVentas_Load;
        }

        private void RefrescarGrid()
        {
            
            dgvVentas.DataSource = Venta.ListarVenta();
        }
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarGrid();
                btnNuevoVenta.Visible = modeloss.Sesion.TienePermiso("Ventas", "Crear");
                btnEditarVenta.Visible = modeloss.Sesion.TienePermiso("Ventas", "Editar");
                btnEliminarVenta.Visible = modeloss.Sesion.TienePermiso("Ventas", "Eliminar");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El formulario abrió correctamente, pero no se pudo conectar con la base de datos.\n\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoRegistro formularioVenta = new FrmNuevoRegistro(TipoRegistro.Venta);
            if (formularioVenta.ShowDialog() == DialogResult.OK)
            {
                RefrescarGrid(); 
            }
        }

        private void btnEditarVenta_Click(object sender, EventArgs e)
        {
            {
                
                if (dgvVentas.SelectedRows.Count > 0)
                {
                    
                    int idVenta = Convert.ToInt32(dgvVentas.CurrentRow.Cells[0].Value);

                    
                    FrmNuevoRegistro formularioVenta = new FrmNuevoRegistro(TipoRegistro.Venta, idVenta);
                    if (formularioVenta.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila para editar.");
                }
            }
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar esta venta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    int idVenta = Convert.ToInt32(dgvVentas.CurrentRow.Cells[0].Value);

                    try
                    {
                        Venta.EliminarVenta(idVenta);
                        RefrescarGrid();
                        MessageBox.Show("Registro eliminado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar la venta.\n\n" + ex.Message,
                            "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void btnActualizarVenta_Click(object sender, EventArgs e)
        {
            RefrescarGrid();
            MessageBox.Show("Datos actualizados.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = Venta.ListarVenta(txtBuscarVenta.Text.Trim());
        }
    }
}

