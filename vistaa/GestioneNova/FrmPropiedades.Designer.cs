namespace vistaa.GestioneNova
{
    partial class FrmPropiedades
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
            this.btnActulizarPropiedad = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPropiedades = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEliminarPropiedad = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarPropiedad = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditarpropiedad = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuevapropiedad = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActulizarPropiedad
            // 
            this.btnActulizarPropiedad.BorderRadius = 10;
            this.btnActulizarPropiedad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActulizarPropiedad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActulizarPropiedad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActulizarPropiedad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActulizarPropiedad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnActulizarPropiedad.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnActulizarPropiedad.ForeColor = System.Drawing.Color.White;
            this.btnActulizarPropiedad.Location = new System.Drawing.Point(870, 175);
            this.btnActulizarPropiedad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActulizarPropiedad.Name = "btnActulizarPropiedad";
            this.btnActulizarPropiedad.Size = new System.Drawing.Size(153, 49);
            this.btnActulizarPropiedad.TabIndex = 56;
            this.btnActulizarPropiedad.Text = "Recargar";
            this.btnActulizarPropiedad.Click += new System.EventHandler(this.btnActulizarPropiedad_Click);
            // 
            // dgvPropiedades
            // 
            this.dgvPropiedades.AllowUserToAddRows = false;
            this.dgvPropiedades.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvPropiedades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPropiedades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPropiedades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPropiedades.BackgroundColor = System.Drawing.Color.White;
            this.dgvPropiedades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPropiedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPropiedades.ColumnHeadersHeight = 40;
            this.dgvPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPropiedades.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPropiedades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPropiedades.Location = new System.Drawing.Point(20, 245);
            this.dgvPropiedades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPropiedades.MultiSelect = false;
            this.dgvPropiedades.Name = "dgvPropiedades";
            this.dgvPropiedades.ReadOnly = true;
            this.dgvPropiedades.RowHeadersVisible = false;
            this.dgvPropiedades.RowHeadersWidth = 62;
            this.dgvPropiedades.RowTemplate.Height = 28;
            this.dgvPropiedades.Size = new System.Drawing.Size(1224, 365);
            this.dgvPropiedades.TabIndex = 51;
            this.dgvPropiedades.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPropiedades.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPropiedades.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvPropiedades.ThemeStyle.ReadOnly = true;
            this.dgvPropiedades.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPropiedades.ThemeStyle.RowsStyle.Height = 28;
            // 
            // btnEliminarPropiedad
            // 
            this.btnEliminarPropiedad.BorderRadius = 10;
            this.btnEliminarPropiedad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPropiedad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPropiedad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarPropiedad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarPropiedad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminarPropiedad.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPropiedad.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPropiedad.Location = new System.Drawing.Point(647, 175);
            this.btnEliminarPropiedad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarPropiedad.Name = "btnEliminarPropiedad";
            this.btnEliminarPropiedad.Size = new System.Drawing.Size(145, 49);
            this.btnEliminarPropiedad.TabIndex = 55;
            this.btnEliminarPropiedad.Text = "Eliminar";
            this.btnEliminarPropiedad.Click += new System.EventHandler(this.btnEliminarPropiedad_Click);
            // 
            // txtBuscarPropiedad
            // 
            this.txtBuscarPropiedad.BorderRadius = 10;
            this.txtBuscarPropiedad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarPropiedad.DefaultText = "Buscar cliente , propiedad o codigo";
            this.txtBuscarPropiedad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarPropiedad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarPropiedad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarPropiedad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarPropiedad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarPropiedad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarPropiedad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarPropiedad.Location = new System.Drawing.Point(224, 108);
            this.txtBuscarPropiedad.Name = "txtBuscarPropiedad";
            this.txtBuscarPropiedad.PlaceholderText = "Buscar por Nombre , DUI o Telefono";
            this.txtBuscarPropiedad.SelectedText = "";
            this.txtBuscarPropiedad.Size = new System.Drawing.Size(447, 39);
            this.txtBuscarPropiedad.TabIndex = 49;
            // 
            // btnEditarpropiedad
            // 
            this.btnEditarpropiedad.BorderRadius = 10;
            this.btnEditarpropiedad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarpropiedad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarpropiedad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarpropiedad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarpropiedad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEditarpropiedad.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarpropiedad.ForeColor = System.Drawing.Color.White;
            this.btnEditarpropiedad.Location = new System.Drawing.Point(408, 175);
            this.btnEditarpropiedad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarpropiedad.Name = "btnEditarpropiedad";
            this.btnEditarpropiedad.Size = new System.Drawing.Size(147, 49);
            this.btnEditarpropiedad.TabIndex = 54;
            this.btnEditarpropiedad.Text = "Editar";
            this.btnEditarpropiedad.Click += new System.EventHandler(this.btnEditarpropiedad_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(733, 108);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 39);
            this.btnBuscar.TabIndex = 50;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevapropiedad
            // 
            this.btnNuevapropiedad.BorderRadius = 10;
            this.btnNuevapropiedad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevapropiedad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevapropiedad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevapropiedad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevapropiedad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(196)))), ((int)(((byte)(127)))));
            this.btnNuevapropiedad.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevapropiedad.ForeColor = System.Drawing.Color.White;
            this.btnNuevapropiedad.Location = new System.Drawing.Point(189, 175);
            this.btnNuevapropiedad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevapropiedad.Name = "btnNuevapropiedad";
            this.btnNuevapropiedad.Size = new System.Drawing.Size(149, 49);
            this.btnNuevapropiedad.TabIndex = 53;
            this.btnNuevapropiedad.Text = "Nuevo";
            this.btnNuevapropiedad.Click += new System.EventHandler(this.btnNuevapropiedad_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(20, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1224, 90);
            this.panel2.TabIndex = 52;
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
            this.label1.Size = new System.Drawing.Size(463, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gestion de Propiedades";
            // 
            // FrmPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 621);
            this.Controls.Add(this.btnActulizarPropiedad);
            this.Controls.Add(this.dgvPropiedades);
            this.Controls.Add(this.btnEliminarPropiedad);
            this.Controls.Add(this.txtBuscarPropiedad);
            this.Controls.Add(this.btnEditarpropiedad);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevapropiedad);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPropiedades";
            this.Text = "FrmPropiedades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnActulizarPropiedad;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPropiedades;
        private Guna.UI2.WinForms.Guna2Button btnEliminarPropiedad;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarPropiedad;
        private Guna.UI2.WinForms.Guna2Button btnEditarpropiedad;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnNuevapropiedad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
