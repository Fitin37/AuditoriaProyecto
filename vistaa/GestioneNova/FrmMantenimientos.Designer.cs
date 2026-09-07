namespace vistaa.GestioneNova
{
    partial class FrmMantenimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnActualizarMantenimiento = new Guna.UI2.WinForms.Guna2Button();
            this.dgvMantenimientos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEliminarMantenimiento = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarMantenimiento = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditarMantenimientos = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuevoMantenimiento = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimientos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizarMantenimiento
            // 
            this.btnActualizarMantenimiento.BorderRadius = 10;
            this.btnActualizarMantenimiento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarMantenimiento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarMantenimiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizarMantenimiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizarMantenimiento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnActualizarMantenimiento.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnActualizarMantenimiento.ForeColor = System.Drawing.Color.White;
            this.btnActualizarMantenimiento.Location = new System.Drawing.Point(839, 173);
            this.btnActualizarMantenimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarMantenimiento.Name = "btnActualizarMantenimiento";
            this.btnActualizarMantenimiento.Size = new System.Drawing.Size(153, 57);
            this.btnActualizarMantenimiento.TabIndex = 29;
            this.btnActualizarMantenimiento.Text = "Recargar";
            this.btnActualizarMantenimiento.Click += new System.EventHandler(this.btnActualizarMantenimiento_Click);
            // 
            // dgvMantenimientos
            // 
            this.dgvMantenimientos.AllowUserToAddRows = false;
            this.dgvMantenimientos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvMantenimientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvMantenimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMantenimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvMantenimientos.BackgroundColor = System.Drawing.Color.White;
            this.dgvMantenimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMantenimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMantenimientos.ColumnHeadersHeight = 40;
            this.dgvMantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMantenimientos.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvMantenimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMantenimientos.Location = new System.Drawing.Point(20, 245);
            this.dgvMantenimientos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMantenimientos.MultiSelect = false;
            this.dgvMantenimientos.Name = "dgvMantenimientos";
            this.dgvMantenimientos.ReadOnly = true;
            this.dgvMantenimientos.RowHeadersVisible = false;
            this.dgvMantenimientos.RowHeadersWidth = 62;
            this.dgvMantenimientos.RowTemplate.Height = 28;
            this.dgvMantenimientos.Size = new System.Drawing.Size(1224, 365);
            this.dgvMantenimientos.TabIndex = 24;
            this.dgvMantenimientos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMantenimientos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMantenimientos.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvMantenimientos.ThemeStyle.ReadOnly = true;
            this.dgvMantenimientos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMantenimientos.ThemeStyle.RowsStyle.Height = 28;
            // 
            // btnEliminarMantenimiento
            // 
            this.btnEliminarMantenimiento.BorderRadius = 10;
            this.btnEliminarMantenimiento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarMantenimiento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarMantenimiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarMantenimiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarMantenimiento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminarMantenimiento.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMantenimiento.ForeColor = System.Drawing.Color.White;
            this.btnEliminarMantenimiento.Location = new System.Drawing.Point(616, 173);
            this.btnEliminarMantenimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarMantenimiento.Name = "btnEliminarMantenimiento";
            this.btnEliminarMantenimiento.Size = new System.Drawing.Size(145, 57);
            this.btnEliminarMantenimiento.TabIndex = 28;
            this.btnEliminarMantenimiento.Text = "Eliminar";
            this.btnEliminarMantenimiento.Click += new System.EventHandler(this.btnEliminarMantenimiento_Click);
            // 
            // txtBuscarMantenimiento
            // 
            this.txtBuscarMantenimiento.BorderRadius = 10;
            this.txtBuscarMantenimiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarMantenimiento.DefaultText = "Buscar mantenimiento";
            this.txtBuscarMantenimiento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarMantenimiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarMantenimiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarMantenimiento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarMantenimiento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarMantenimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarMantenimiento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarMantenimiento.Location = new System.Drawing.Point(231, 112);
            this.txtBuscarMantenimiento.Name = "txtBuscarMantenimiento";
            this.txtBuscarMantenimiento.PlaceholderText = "Buscar por descripcion o estado";
            this.txtBuscarMantenimiento.SelectedText = "";
            this.txtBuscarMantenimiento.Size = new System.Drawing.Size(447, 39);
            this.txtBuscarMantenimiento.TabIndex = 22;
            // 
            // btnEditarMantenimientos
            // 
            this.btnEditarMantenimientos.BorderRadius = 10;
            this.btnEditarMantenimientos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarMantenimientos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarMantenimientos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarMantenimientos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarMantenimientos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEditarMantenimientos.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMantenimientos.ForeColor = System.Drawing.Color.White;
            this.btnEditarMantenimientos.Location = new System.Drawing.Point(377, 173);
            this.btnEditarMantenimientos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarMantenimientos.Name = "btnEditarMantenimientos";
            this.btnEditarMantenimientos.Size = new System.Drawing.Size(147, 57);
            this.btnEditarMantenimientos.TabIndex = 27;
            this.btnEditarMantenimientos.Text = "Editar";
            this.btnEditarMantenimientos.Click += new System.EventHandler(this.btnEditarMantenimientos_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(711, 112);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 39);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevoMantenimiento
            // 
            this.btnNuevoMantenimiento.BorderRadius = 10;
            this.btnNuevoMantenimiento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoMantenimiento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoMantenimiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevoMantenimiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevoMantenimiento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(196)))), ((int)(((byte)(127)))));
            this.btnNuevoMantenimiento.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMantenimiento.ForeColor = System.Drawing.Color.White;
            this.btnNuevoMantenimiento.Location = new System.Drawing.Point(157, 173);
            this.btnNuevoMantenimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevoMantenimiento.Name = "btnNuevoMantenimiento";
            this.btnNuevoMantenimiento.Size = new System.Drawing.Size(149, 57);
            this.btnNuevoMantenimiento.TabIndex = 26;
            this.btnNuevoMantenimiento.Text = "Nuevo";
            this.btnNuevoMantenimiento.Click += new System.EventHandler(this.btnNuevoMantenimiento_Click);
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
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(113, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gestion de Mantenimientos\r\n";
            // 
            // FrmMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 621);
            this.Controls.Add(this.btnActualizarMantenimiento);
            this.Controls.Add(this.dgvMantenimientos);
            this.Controls.Add(this.btnEliminarMantenimiento);
            this.Controls.Add(this.txtBuscarMantenimiento);
            this.Controls.Add(this.btnEditarMantenimientos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevoMantenimiento);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMantenimientos";
            this.Text = "FrmMantenimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimientos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnActualizarMantenimiento;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMantenimientos;
        private Guna.UI2.WinForms.Guna2Button btnEliminarMantenimiento;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarMantenimiento;
        private Guna.UI2.WinForms.Guna2Button btnEditarMantenimientos;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnNuevoMantenimiento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
