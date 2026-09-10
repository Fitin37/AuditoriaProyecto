using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ReproducirError
{
    public class FrmReproducirParametro : Form
    {
        private Button btnEjecutar;
        private TextBox txtCadena;
        private DataGridView dgv;

        public FrmReproducirParametro()
        {
            Text = "Reproducir error parámetro SQL";
            Width = 800;
            Height = 500;

            txtCadena = new TextBox { Dock = DockStyle.Top, Text = "Data Source=MI_SERVIDOR;Initial Catalog=MI_BASE;Integrated Security=True" };
            btnEjecutar = new Button { Text = "Ejecutar consulta (reproducir)", Dock = DockStyle.Top, Height = 30 };
            dgv = new DataGridView { Dock = DockStyle.Fill };

            btnEjecutar.Click += BtnEjecutar_Click;

            Controls.Add(dgv);
            Controls.Add(btnEjecutar);
            Controls.Add(txtCadena);
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            // Consulta que usa el parámetro @idEditar
            string sql = @"SELECT c.IdCliente, (ISNULL(c.Nombres,'') + ' ' + ISNULL(c.Apellidos,'')) AS Nombre
FROM Clientes c
WHERE c.IdCliente NOT IN (SELECT ISNULL(IdCliente,0) FROM Usuarios WHERE IdCliente IS NOT NULL)
OR c.IdCliente = @idEditar
ORDER BY Nombre";

            // Aquí se añade intencionadamente un parámetro con nombre diferente (@id)
            // para reproducir la excepción: "Debe declarar la variable escalar '@idEditar'."
            using (SqlConnection conexion = new SqlConnection(txtCadena.Text))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion))
            {
                adaptador.SelectCommand.Parameters.AddWithValue("@id", 0); // nombre distinto al usado en la consulta

                DataTable tabla = new DataTable();
                try
                {
                    adaptador.Fill(tabla);
                    dgv.DataSource = tabla;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SqlException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
