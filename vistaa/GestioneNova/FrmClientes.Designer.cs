namespace vistaa.GestioneNova
{
    partial class FrmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnActualizarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.dgvCliente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEliminarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuevoCliente = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.BorderRadius = 10;
            this.btnActualizarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizarCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnActualizarCliente.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnActualizarCliente.ForeColor = System.Drawing.Color.White;
            this.btnActualizarCliente.Location = new System.Drawing.Point(880, 178);
            this.btnActualizarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(153, 57);
            this.btnActualizarCliente.TabIndex = 47;
            this.btnActualizarCliente.Text = "Recargar";
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.ColumnHeadersHeight = 40;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCliente.Location = new System.Drawing.Point(20, 245);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 62;
            this.dgvCliente.RowTemplate.Height = 28;
            this.dgvCliente.Size = new System.Drawing.Size(1224, 365);
            this.dgvCliente.TabIndex = 42;
            this.dgvCliente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCliente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCliente.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvCliente.ThemeStyle.ReadOnly = true;
            this.dgvCliente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCliente.ThemeStyle.RowsStyle.Height = 28;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BorderRadius = 10;
            this.btnEliminarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminarCliente.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCliente.Location = new System.Drawing.Point(657, 178);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(145, 57);
            this.btnEliminarCliente.TabIndex = 46;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BorderRadius = 10;
            this.txtBuscarCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarCliente.DefaultText = "Buscar cliente , propiedad o codigo";
            this.txtBuscarCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarCliente.Location = new System.Drawing.Point(237, 111);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.PlaceholderText = "Buscar por Nombre , DUI o Telefono";
            this.txtBuscarCliente.SelectedText = "";
            this.txtBuscarCliente.Size = new System.Drawing.Size(447, 39);
            this.txtBuscarCliente.TabIndex = 40;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BorderRadius = 10;
            this.btnEditarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEditarCliente.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.ForeColor = System.Drawing.Color.White;
            this.btnEditarCliente.Location = new System.Drawing.Point(418, 178);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(147, 57);
            this.btnEditarCliente.TabIndex = 45;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(747, 111);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 39);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BorderRadius = 10;
            this.btnNuevoCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevoCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevoCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(196)))), ((int)(((byte)(127)))));
            this.btnNuevoCliente.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.Location = new System.Drawing.Point(198, 178);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(149, 57);
            this.btnNuevoCliente.TabIndex = 44;
            this.btnNuevoCliente.Text = " Nuevo";
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
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
            this.panel2.TabIndex = 43;
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
            this.label1.Size = new System.Drawing.Size(380, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gestion de Clientes";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 621);
            this.Controls.Add(this.btnActualizarCliente);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnActualizarCliente;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCliente;
        private Guna.UI2.WinForms.Guna2Button btnEliminarCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarCliente;
        private Guna.UI2.WinForms.Guna2Button btnEditarCliente;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnNuevoCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
