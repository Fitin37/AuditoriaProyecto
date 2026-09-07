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
    public partial class FrmPropiedades : Form
    {
        public FrmPropiedades(int idPropiedad) : this()
        {
        }
        public FrmPropiedades(bool soloLectura) : this() { btnNuevapropiedad.Visible=!soloLectura; btnEditarpropiedad.Visible=!soloLectura; btnEliminarPropiedad.Visible=!soloLectura; }

        public FrmPropiedades()
        {
            InitializeComponent();
            this.Load += FrmPropiedades_Load;
        }

        private void RefrescarGrid()
        {

            dgvPropiedades.DataSource = Propiedad.Listar();
        }

        private void FrmPropiedades_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarGrid();
                // Ajustar visibilidad según permisos del rol
                btnNuevapropiedad.Visible = modeloss.Sesion.TienePermiso("Propiedades", "Crear");
                btnEditarpropiedad.Visible = modeloss.Sesion.TienePermiso("Propiedades", "Editar");
                btnEliminarPropiedad.Visible = modeloss.Sesion.TienePermiso("Propiedades", "Eliminar");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El formulario abrió correctamente, pero no se pudo conectar con la base de datos.\n\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevapropiedad_Click(object sender, EventArgs e)
        {
            FrmNuevoRegistro formularioPropiedad = new FrmNuevoRegistro(TipoRegistro.Propiedad);
            if (formularioPropiedad.ShowDialog() == DialogResult.OK)
            {
                RefrescarGrid();
            }
        }

        private void btnEditarpropiedad_Click(object sender, EventArgs e)
        {

            if (dgvPropiedades.SelectedRows.Count > 0)
            {

                int idPropiedad = Convert.ToInt32(dgvPropiedades.CurrentRow.Cells[0].Value);


                FrmNuevoRegistro formularioPropiedad = new FrmNuevoRegistro(TipoRegistro.Propiedad, idPropiedad);
                if (formularioPropiedad.ShowDialog() == DialogResult.OK)
                {
                    RefrescarGrid();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.");
            }
        }

        private void btnEliminarPropiedad_Click(object sender, EventArgs e)
        {
            if (dgvPropiedades.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar esta propiedad?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    int idPropiedad = Convert.ToInt32(dgvPropiedades.CurrentRow.Cells[0].Value);

                    try
                    {
                        Propiedad.Eliminar(idPropiedad);
                        RefrescarGrid();
                        MessageBox.Show("Propiedad y registros relacionados eliminados correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar la propiedad.\n\n" + ex.Message,
                            "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void btnActulizarPropiedad_Click(object sender, EventArgs e)
        {
            RefrescarGrid();
            MessageBox.Show("Datos actualizados.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPropiedades.DataSource = Propiedad.Listar(txtBuscarPropiedad.Text.Trim());
        }
    }
}
