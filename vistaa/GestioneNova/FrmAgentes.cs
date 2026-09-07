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
    public partial class FrmAgentes : Form
    {
        public FrmAgentes(int idAgente) : this()
        {
        }

        public FrmAgentes()
        {
            InitializeComponent();
            this.Load += FrmAlquileres_Load;
        }

        private void RefrescarGrid()
        {

            dgvAgentes.DataSource = Agente.Listar();
        }

        private void FrmAlquileres_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarGrid();
                btnNuevoAgente.Visible = modeloss.Sesion.TienePermiso("Agentes", "Crear");
                btnEditarAgentes.Visible = modeloss.Sesion.TienePermiso("Agentes", "Editar");
                btnEliminarAgente.Visible = modeloss.Sesion.TienePermiso("Agentes", "Eliminar");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El formulario abrió correctamente, pero no se pudo conectar con la base de datos.\n\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnNuevoAgente_Click(object sender, EventArgs e)
        {
            FrmNuevoRegistro formularioAgente = new FrmNuevoRegistro(TipoRegistro.Agente);
            if (formularioAgente.ShowDialog() == DialogResult.OK)
            {
                RefrescarGrid();
            }
        }

        private void btnEditarAgentes_Click(object sender, EventArgs e)
        {
            if (dgvAgentes.SelectedRows.Count > 0)
            {

                int idAgente = Convert.ToInt32(dgvAgentes.CurrentRow.Cells[0].Value);


                FrmNuevoRegistro formularioAgente = new FrmNuevoRegistro(TipoRegistro.Agente, idAgente);
                if (formularioAgente.ShowDialog() == DialogResult.OK)
                {
                    RefrescarGrid();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.");
            }
        }

        private void btnEliminarAgente_Click(object sender, EventArgs e)
        {
            if (dgvAgentes.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    int idAgente = Convert.ToInt32(dgvAgentes.CurrentRow.Cells[0].Value);

                    try
                    {
                        Agente.Eliminar(idAgente);
                        RefrescarGrid();
                        MessageBox.Show("Agente y citas relacionadas eliminados correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar el agente.\n\n" + ex.Message,
                            "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void btnActualizarAgente_Click(object sender, EventArgs e)
        {
            RefrescarGrid();
            MessageBox.Show("Datos actualizados.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAgentes.DataSource = Agente.Listar(txtBuscarAgente.Text.Trim());
        }
    }
}
