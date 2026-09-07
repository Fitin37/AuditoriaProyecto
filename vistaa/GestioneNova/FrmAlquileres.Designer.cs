namespace vistaa.GestioneNova
{
    partial class FrmAlquileres
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
            this.btnActualizarAlquiler = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAlquileres = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEliminarAlquiler = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarAlquiler = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditarAlquiler = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuevoAlquiler = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizarAlquiler
            // 
            this.btnActualizarAlquiler.BorderRadius = 10;
            this.btnActualizarAlquiler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarAlquiler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarAlquiler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizarAlquiler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizarAlquiler.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnActualizarAlquiler.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnActualizarAlquiler.ForeColor = System.Drawing.Color.White;
            this.btnActualizarAlquiler.Location = new System.Drawing.Point(855, 168);
            this.btnActualizarAlquiler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarAlquiler.Name = "btnActualizarAlquiler";
            this.btnActualizarAlquiler.Size = new System.Drawing.Size(153, 51);
            this.btnActualizarAlquiler.TabIndex = 38;
            this.btnActualizarAlquiler.Text = "Recargar";
            this.btnActualizarAlquiler.Click += new System.EventHandler(this.btnActualizarAlquiler_Click);
            // 
            // dgvAlquileres
            // 
            this.dgvAlquileres.AllowUserToAddRows = false;
            this.dgvAlquileres.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvAlquileres.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvAlquileres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlquileres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvAlquileres.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlquileres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlquileres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlquileres.ColumnHeadersHeight = 40;
            this.dgvAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlquileres.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvAlquileres.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAlquileres.Location = new System.Drawing.Point(20, 245);
            this.dgvAlquileres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAlquileres.MultiSelect = false;
            this.dgvAlquileres.Name = "dgvAlquileres";
            this.dgvAlquileres.ReadOnly = true;
            this.dgvAlquileres.RowHeadersVisible = false;
            this.dgvAlquileres.RowHeadersWidth = 62;
            this.dgvAlquileres.RowTemplate.Height = 28;
            this.dgvAlquileres.Size = new System.Drawing.Size(1224, 365);
            this.dgvAlquileres.TabIndex = 33;
            this.dgvAlquileres.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAlquileres.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAlquileres.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvAlquileres.ThemeStyle.ReadOnly = true;
            this.dgvAlquileres.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAlquileres.ThemeStyle.RowsStyle.Height = 28;
            // 
            // btnEliminarAlquiler
            // 
            this.btnEliminarAlquiler.BorderRadius = 10;
            this.btnEliminarAlquiler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarAlquiler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarAlquiler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarAlquiler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarAlquiler.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminarAlquiler.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlquiler.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAlquiler.Location = new System.Drawing.Point(631, 168);
            this.btnEliminarAlquiler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarAlquiler.Name = "btnEliminarAlquiler";
            this.btnEliminarAlquiler.Size = new System.Drawing.Size(145, 51);
            this.btnEliminarAlquiler.TabIndex = 37;
            this.btnEliminarAlquiler.Text = "Eliminar";
            this.btnEliminarAlquiler.Click += new System.EventHandler(this.btnEliminarAlquiler_Click);
            // 
            // txtBuscarAlquiler
            // 
            this.txtBuscarAlquiler.BorderRadius = 10;
            this.txtBuscarAlquiler.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarAlquiler.DefaultText = "Buscar cliente , propiedad o codigo";
            this.txtBuscarAlquiler.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarAlquiler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarAlquiler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarAlquiler.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarAlquiler.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarAlquiler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarAlquiler.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarAlquiler.Location = new System.Drawing.Point(220, 101);
            this.txtBuscarAlquiler.Name = "txtBuscarAlquiler";
            this.txtBuscarAlquiler.PlaceholderText = "Buscar por Nombre , DUI o Telefono";
            this.txtBuscarAlquiler.SelectedText = "";
            this.txtBuscarAlquiler.Size = new System.Drawing.Size(447, 39);
            this.txtBuscarAlquiler.TabIndex = 31;
            // 
            // btnEditarAlquiler
            // 
            this.btnEditarAlquiler.BorderRadius = 10;
            this.btnEditarAlquiler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarAlquiler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarAlquiler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarAlquiler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarAlquiler.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEditarAlquiler.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAlquiler.ForeColor = System.Drawing.Color.White;
            this.btnEditarAlquiler.Location = new System.Drawing.Point(393, 168);
            this.btnEditarAlquiler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarAlquiler.Name = "btnEditarAlquiler";
            this.btnEditarAlquiler.Size = new System.Drawing.Size(147, 51);
            this.btnEditarAlquiler.TabIndex = 36;
            this.btnEditarAlquiler.Text = "Editar";
            this.btnEditarAlquiler.Click += new System.EventHandler(this.btnEditarAlquiler_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(739, 101);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 39);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevoAlquiler
            // 
            this.btnNuevoAlquiler.BorderRadius = 10;
            this.btnNuevoAlquiler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoAlquiler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoAlquiler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevoAlquiler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevoAlquiler.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(196)))), ((int)(((byte)(127)))));
            this.btnNuevoAlquiler.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAlquiler.ForeColor = System.Drawing.Color.White;
            this.btnNuevoAlquiler.Location = new System.Drawing.Point(173, 168);
            this.btnNuevoAlquiler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevoAlquiler.Name = "btnNuevoAlquiler";
            this.btnNuevoAlquiler.Size = new System.Drawing.Size(149, 51);
            this.btnNuevoAlquiler.TabIndex = 35;
            this.btnNuevoAlquiler.Text = "Nuevo";
            this.btnNuevoAlquiler.Click += new System.EventHandler(this.btnNuevoAlquiler_Click);
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
            this.panel2.TabIndex = 34;
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
            this.label1.Size = new System.Drawing.Size(422, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gestion de Alquileres";
            // 
            // FrmAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 621);
            this.Controls.Add(this.btnActualizarAlquiler);
            this.Controls.Add(this.dgvAlquileres);
            this.Controls.Add(this.btnEliminarAlquiler);
            this.Controls.Add(this.txtBuscarAlquiler);
            this.Controls.Add(this.btnEditarAlquiler);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevoAlquiler);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAlquileres";
            this.Text = "FrmAlquileres";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnActualizarAlquiler;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAlquileres;
        private Guna.UI2.WinForms.Guna2Button btnEliminarAlquiler;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarAlquiler;
        private Guna.UI2.WinForms.Guna2Button btnEditarAlquiler;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnNuevoAlquiler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
