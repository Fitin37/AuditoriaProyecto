namespace vistaa.GestioneNova
{
    partial class FrmAgentes
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
            this.btnActualizarAgente = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAgentes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEliminarAgente = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarAgente = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditarAgentes = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuevoAgente = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizarAgente
            // 
            this.btnActualizarAgente.BorderRadius = 10;
            this.btnActualizarAgente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarAgente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarAgente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizarAgente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizarAgente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnActualizarAgente.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnActualizarAgente.ForeColor = System.Drawing.Color.White;
            this.btnActualizarAgente.Location = new System.Drawing.Point(839, 173);
            this.btnActualizarAgente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarAgente.Name = "btnActualizarAgente";
            this.btnActualizarAgente.Size = new System.Drawing.Size(153, 57);
            this.btnActualizarAgente.TabIndex = 29;
            this.btnActualizarAgente.Text = "Recargar";
            this.btnActualizarAgente.Click += new System.EventHandler(this.btnActualizarAgente_Click);
            // 
            // dgvAgentes
            // 
            this.dgvAgentes.AllowUserToAddRows = false;
            this.dgvAgentes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvAgentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvAgentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvAgentes.BackgroundColor = System.Drawing.Color.White;
            this.dgvAgentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAgentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgentes.ColumnHeadersHeight = 40;
            this.dgvAgentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgentes.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvAgentes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAgentes.Location = new System.Drawing.Point(20, 245);
            this.dgvAgentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAgentes.MultiSelect = false;
            this.dgvAgentes.Name = "dgvAgentes";
            this.dgvAgentes.ReadOnly = true;
            this.dgvAgentes.RowHeadersVisible = false;
            this.dgvAgentes.RowHeadersWidth = 62;
            this.dgvAgentes.RowTemplate.Height = 28;
            this.dgvAgentes.Size = new System.Drawing.Size(1224, 365);
            this.dgvAgentes.TabIndex = 24;
            this.dgvAgentes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAgentes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAgentes.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvAgentes.ThemeStyle.ReadOnly = true;
            this.dgvAgentes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAgentes.ThemeStyle.RowsStyle.Height = 28;
            // 
            // btnEliminarAgente
            // 
            this.btnEliminarAgente.BorderRadius = 10;
            this.btnEliminarAgente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarAgente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarAgente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarAgente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarAgente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminarAgente.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAgente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAgente.Location = new System.Drawing.Point(616, 173);
            this.btnEliminarAgente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarAgente.Name = "btnEliminarAgente";
            this.btnEliminarAgente.Size = new System.Drawing.Size(145, 57);
            this.btnEliminarAgente.TabIndex = 28;
            this.btnEliminarAgente.Text = "Eliminar";
            this.btnEliminarAgente.Click += new System.EventHandler(this.btnEliminarAgente_Click);
            // 
            // txtBuscarAgente
            // 
            this.txtBuscarAgente.BorderRadius = 10;
            this.txtBuscarAgente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarAgente.DefaultText = "Buscar cliente , propiedad o codigo";
            this.txtBuscarAgente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarAgente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarAgente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarAgente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarAgente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarAgente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarAgente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarAgente.Location = new System.Drawing.Point(231, 112);
            this.txtBuscarAgente.Name = "txtBuscarAgente";
            this.txtBuscarAgente.PlaceholderText = "Buscar por Nombre , DUI o Telefono";
            this.txtBuscarAgente.SelectedText = "";
            this.txtBuscarAgente.Size = new System.Drawing.Size(447, 39);
            this.txtBuscarAgente.TabIndex = 22;
            // 
            // btnEditarAgentes
            // 
            this.btnEditarAgentes.BorderRadius = 10;
            this.btnEditarAgentes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarAgentes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarAgentes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarAgentes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarAgentes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEditarAgentes.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAgentes.ForeColor = System.Drawing.Color.White;
            this.btnEditarAgentes.Location = new System.Drawing.Point(377, 173);
            this.btnEditarAgentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarAgentes.Name = "btnEditarAgentes";
            this.btnEditarAgentes.Size = new System.Drawing.Size(147, 57);
            this.btnEditarAgentes.TabIndex = 27;
            this.btnEditarAgentes.Text = "Editar";
            this.btnEditarAgentes.Click += new System.EventHandler(this.btnEditarAgentes_Click);
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
            // btnNuevoAgente
            // 
            this.btnNuevoAgente.BorderRadius = 10;
            this.btnNuevoAgente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoAgente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoAgente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevoAgente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevoAgente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(196)))), ((int)(((byte)(127)))));
            this.btnNuevoAgente.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAgente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoAgente.Location = new System.Drawing.Point(157, 173);
            this.btnNuevoAgente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevoAgente.Name = "btnNuevoAgente";
            this.btnNuevoAgente.Size = new System.Drawing.Size(149, 57);
            this.btnNuevoAgente.TabIndex = 26;
            this.btnNuevoAgente.Text = "Nuevo";
            this.btnNuevoAgente.Click += new System.EventHandler(this.btnNuevoAgente_Click);
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
            this.label1.Text = "Gestion de Agentes\r\n";
            // 
            // FrmAgentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 621);
            this.Controls.Add(this.btnActualizarAgente);
            this.Controls.Add(this.dgvAgentes);
            this.Controls.Add(this.btnEliminarAgente);
            this.Controls.Add(this.txtBuscarAgente);
            this.Controls.Add(this.btnEditarAgentes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevoAgente);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAgentes";
            this.Text = "FrmAgentes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnActualizarAgente;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAgentes;
        private Guna.UI2.WinForms.Guna2Button btnEliminarAgente;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarAgente;
        private Guna.UI2.WinForms.Guna2Button btnEditarAgentes;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnNuevoAgente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
