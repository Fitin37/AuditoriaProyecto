using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ReproducirError
{
    public class FrmCrearUsuario : Form
    {
        private TextBox txtCadena;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private ComboBox cmbCliente;
        private Button btnGuardar;

        public FrmCrearUsuario()
        {
            Text = "Crear Usuario";
            Width = 600;
            Height = 360;

            txtCadena = new TextBox { Dock = DockStyle.Top, Text = "Data Source=MI_SERVIDOR;Initial Catalog=MI_BASE;Integrated Security=True" };

            var panel = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(10), ColumnCount = 2 };
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65));

            panel.RowStyles.Clear();

            void AddRow(string labelText, Control control)
            {
                int row = panel.RowCount++;
                panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36));
                var lbl = new Label { Text = labelText, TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill };
                control.Dock = DockStyle.Fill;
                panel.Controls.Add(lbl, 0, row);
                panel.Controls.Add(control, 1, row);
            }

            txtUsuario = new TextBox();
            txtClave = new TextBox { UseSystemPasswordChar = true };
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            cmbCliente = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList }; // opcional

            AddRow("Usuario:", txtUsuario);
            AddRow("Clave:", txtClave);
            AddRow("Nombres:", txtNombres);
            AddRow("Apellidos:", txtApellidos);
            AddRow("Cliente asociado (opcional):", cmbCliente);

            btnGuardar = new Button { Text = "Guardar", Height = 34, Dock = DockStyle.Right };
            btnGuardar.Click += BtnGuardar_Click;

            var bottomPanel = new Panel { Dock = DockStyle.Bottom, Height = 48, Padding = new Padding(10) };
            bottomPanel.Controls.Add(btnGuardar);

            Controls.Add(panel);
            Controls.Add(bottomPanel);
            Controls.Add(txtCadena);

            Load += FrmCrearUsuario_Load;
        }

        private void FrmCrearUsuario_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            string conn = txtCadena.Text;
            string sql = @"SELECT IdCliente, (ISNULL(Nombres,'') + ' ' + ISNULL(Apellidos,'')) AS Nombre
FROM Clientes c
WHERE c.IdCliente NOT IN (SELECT ISNULL(IdCliente,0) FROM Usuarios WHERE IdCliente IS NOT NULL)
ORDER BY Nombre";

            try
            {
                using (SqlConnection conexion = new SqlConnection(conn))
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conexion))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbCliente.DataSource = dt;
                    cmbCliente.DisplayMember = "Nombre";
                    cmbCliente.ValueMember = "IdCliente";
                    cmbCliente.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text;
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Usuario y clave son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string conn = txtCadena.Text;
            string sqlInsert = @"INSERT INTO Usuarios (Usuario, Clave, Nombres, Apellidos, IdCliente)
VALUES (@usuario, @clave, @nombres, @apellidos, @idCliente)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(sqlInsert, conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@clave", clave);
                    cmd.Parameters.AddWithValue("@nombres", (object)nombres ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@apellidos", (object)apellidos ?? DBNull.Value);

                    if (cmbCliente.SelectedIndex >= 0)
                        cmd.Parameters.AddWithValue("@idCliente", cmbCliente.SelectedValue);
                    else
                        cmd.Parameters.AddWithValue("@idCliente", DBNull.Value);

                    conexion.Open();
                    int afectados = cmd.ExecuteNonQuery();

                    if (afectados > 0)
                        MessageBox.Show("Usuario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se creó el usuario.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SqlException: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
