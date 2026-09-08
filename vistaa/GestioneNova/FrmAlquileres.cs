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
    public partial class FrmAlquileres : Form
    {
        public FrmAlquileres(int idVenta) : this()
        {
        }
        public FrmAlquileres(bool soloLectura) : this() { btnNuevoAlquiler.Visible=!soloLectura; btnEditarAlquiler.Visible=!soloLectura; btnEliminarAlquiler.Visible=!soloLectura; }

        public FrmAlquileres()
        {
            InitializeComponent();
            this.Load += FrmAlquileres_Load;
        }

        private void RefrescarGrid()
        {

            dgvAlquileres.DataSource = Alquiler.ListarAlquiler1();
        }

        private void FrmAlquileres_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarGrid();
                btnNuevoAlquiler.Visible = modeloss.Sesion.TienePermiso("Alquileres", "Crear");
                btnEditarAlquiler.Visible = modeloss.Sesion.TienePermiso("Alquileres", "Editar");
                btnEliminarAlquiler.Visible = modeloss.Sesion.TienePermiso("Alquileres", "Eliminar");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El formulario abrió correctamente, pero no se pudo conectar con la base de datos.\n\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnNuevoAlquiler_Click(object sender, EventArgs e)
        {
            FrmNuevoRegistro formularioAlquiler = new FrmNuevoRegistro(TipoRegistro.Alquiler);
            if (formularioAlquiler.ShowDialog() == DialogResult.OK)
            {
                RefrescarGrid();
            }
        }

        private void btnEditarAlquiler_Click(object sender, EventArgs e)
        {
            if (dgvAlquileres.SelectedRows.Count > 0)
            {

                int idAlquiler = Convert.ToInt32(dgvAlquileres.CurrentRow.Cells[0].Value);


                FrmNuevoRegistro formularioAlquiler = new FrmNuevoRegistro(TipoRegistro.Alquiler, idAlquiler);
                if (formularioAlquiler.ShowDialog() == DialogResult.OK)
                {
                    RefrescarGrid();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.");
            }
        }

        private void btnEliminarAlquiler_Click(object sender, EventArgs e)
        {
            if (dgvAlquileres.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    int idAlquiler = Convert.ToInt32(dgvAlquileres.CurrentRow.Cells[0].Value);

                    try
                    {
                        Alquiler.Eliminar(idAlquiler);
                        RefrescarGrid();
                        MessageBox.Show("Alquiler y pagos relacionados eliminados correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar el alquiler.\n\n" + ex.Message,
                            "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void btnActualizarAlquiler_Click(object sender, EventArgs e)
        {
            RefrescarGrid();
            MessageBox.Show("Datos actualizados.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAlquileres.DataSource = Alquiler.ListarAlquiler(txtBuscarAlquiler.Text.Trim());
        }
    }
}
