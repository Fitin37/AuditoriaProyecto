namespace vistaa.GestioneNova
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnActualizarVenta = new Guna.UI2.WinForms.Guna2Button();
            this.dgvVentas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEliminarVenta = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarVenta = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditarVenta = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuevoVenta = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizarVenta
            // 
            this.btnActualizarVenta.BorderRadius = 10;
            this.btnActualizarVenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarVenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizarVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizarVenta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnActualizarVenta.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnActualizarVenta.ForeColor = System.Drawing.Color.White;
            this.btnActualizarVenta.Location = new System.Drawing.Point(872, 179);
            this.btnActualizarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarVenta.Name = "btnActualizarVenta";
            this.btnActualizarVenta.Size = new System.Drawing.Size(153, 56);
            this.btnActualizarVenta.TabIndex = 65;
            this.btnActualizarVenta.Text = "Recargar";
            this.btnActualizarVenta.Click += new System.EventHandler(this.btnActualizarVenta_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.ColumnHeadersHeight = 40;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVentas.Location = new System.Drawing.Point(20, 245);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowHeadersWidth = 62;
            this.dgvVentas.RowTemplate.Height = 28;
            this.dgvVentas.Size = new System.Drawing.Size(1224, 365);
            this.dgvVentas.TabIndex = 60;
            this.dgvVentas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVentas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVentas.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvVentas.ThemeStyle.ReadOnly = true;
            this.dgvVentas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVentas.ThemeStyle.RowsStyle.Height = 28;
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.BorderRadius = 10;
            this.btnEliminarVenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarVenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarVenta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminarVenta.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVenta.ForeColor = System.Drawing.Color.White;
            this.btnEliminarVenta.Location = new System.Drawing.Point(649, 179);
            this.btnEliminarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(145, 56);
            this.btnEliminarVenta.TabIndex = 64;
            this.btnEliminarVenta.Text = "Eliminar";
            this.btnEliminarVenta.Click += new System.EventHandler(this.btnEliminarVenta_Click);
            // 
            // txtBuscarVenta
            // 
            this.txtBuscarVenta.BorderRadius = 10;
            this.txtBuscarVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarVenta.DefaultText = "Buscar cliente , propiedad o codigo";
            this.txtBuscarVenta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarVenta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarVenta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarVenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarVenta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarVenta.Location = new System.Drawing.Point(246, 112);
            this.txtBuscarVenta.Name = "txtBuscarVenta";
            this.txtBuscarVenta.PlaceholderText = "Buscar por Nombre , DUI o Telefono";
            this.txtBuscarVenta.SelectedText = "";
            this.txtBuscarVenta.Size = new System.Drawing.Size(447, 39);
            this.txtBuscarVenta.TabIndex = 58;
            // 
            // btnEditarVenta
            // 
            this.btnEditarVenta.BorderRadius = 10;
            this.btnEditarVenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarVenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarVenta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEditarVenta.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarVenta.ForeColor = System.Drawing.Color.White;
            this.btnEditarVenta.Location = new System.Drawing.Point(410, 179);
            this.btnEditarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarVenta.Name = "btnEditarVenta";
            this.btnEditarVenta.Size = new System.Drawing.Size(147, 56);
            this.btnEditarVenta.TabIndex = 63;
            this.btnEditarVenta.Text = "Editar";
            this.btnEditarVenta.Click += new System.EventHandler(this.btnEditarVenta_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BorderRadius = 10;
            this.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(196)))), ((int)(((byte)(127)))));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(753, 112);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 39);
            this.btnBuscar.TabIndex = 59;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevoVenta
            // 
            this.btnNuevoVenta.BorderRadius = 10;
            this.btnNuevoVenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoVenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevoVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevoVenta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(196)))), ((int)(((byte)(127)))));
            this.btnNuevoVenta.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoVenta.ForeColor = System.Drawing.Color.White;
            this.btnNuevoVenta.Location = new System.Drawing.Point(190, 179);
            this.btnNuevoVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoVenta.Name = "btnNuevoVenta";
            this.btnNuevoVenta.Size = new System.Drawing.Size(149, 56);
            this.btnNuevoVenta.TabIndex = 62;
            this.btnNuevoVenta.Text = "Nuevo";
            this.btnNuevoVenta.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(20, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1224, 90);
            this.panel2.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gestion de Ventas";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 621);
            this.Controls.Add(this.btnActualizarVenta);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnEliminarVenta);
            this.Controls.Add(this.txtBuscarVenta);
            this.Controls.Add(this.btnEditarVenta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevoVenta);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnActualizarVenta;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVentas;
        private Guna.UI2.WinForms.Guna2Button btnEliminarVenta;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarVenta;
        private Guna.UI2.WinForms.Guna2Button btnEditarVenta;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnNuevoVenta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
