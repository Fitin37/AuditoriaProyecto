namespace vistaa.GestioneNova
{
    partial class FrmCitas
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
            this.btnActualizarCita = new Guna.UI2.WinForms.Guna2Button();
            this.dgvCitas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEliminarCita = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarCita = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditarCitas = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuevoCita = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizarCita
            // 
            this.btnActualizarCita.BorderRadius = 10;
            this.btnActualizarCita.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarCita.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarCita.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizarCita.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizarCita.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnActualizarCita.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnActualizarCita.ForeColor = System.Drawing.Color.White;
            this.btnActualizarCita.Location = new System.Drawing.Point(839, 173);
            this.btnActualizarCita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarCita.Name = "btnActualizarCita";
            this.btnActualizarCita.Size = new System.Drawing.Size(153, 57);
            this.btnActualizarCita.TabIndex = 29;
            this.btnActualizarCita.Text = "Recargar";
            this.btnActualizarCita.Click += new System.EventHandler(this.btnActualizarCita_Click);
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCitas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.ColumnHeadersHeight = 40;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCitas.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCitas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCitas.Location = new System.Drawing.Point(20, 245);
            this.dgvCitas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCitas.MultiSelect = false;
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.RowHeadersVisible = false;
            this.dgvCitas.RowHeadersWidth = 62;
            this.dgvCitas.RowTemplate.Height = 28;
            this.dgvCitas.Size = new System.Drawing.Size(1224, 365);
            this.dgvCitas.TabIndex = 24;
            this.dgvCitas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCitas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCitas.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvCitas.ThemeStyle.ReadOnly = true;
            this.dgvCitas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCitas.ThemeStyle.RowsStyle.Height = 28;
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.BorderRadius = 10;
            this.btnEliminarCita.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarCita.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarCita.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarCita.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarCita.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminarCita.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCita.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCita.Location = new System.Drawing.Point(616, 173);
            this.btnEliminarCita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(145, 57);
            this.btnEliminarCita.TabIndex = 28;
            this.btnEliminarCita.Text = "Eliminar";
            this.btnEliminarCita.Click += new System.EventHandler(this.btnEliminarCita_Click);
            // 
            // txtBuscarCita
            // 
            this.txtBuscarCita.BorderRadius = 10;
            this.txtBuscarCita.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarCita.DefaultText = "Buscar cita";
            this.txtBuscarCita.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarCita.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarCita.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarCita.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarCita.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarCita.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarCita.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarCita.Location = new System.Drawing.Point(231, 112);
            this.txtBuscarCita.Name = "txtBuscarCita";
            this.txtBuscarCita.PlaceholderText = "Buscar por estado";
            this.txtBuscarCita.SelectedText = "";
            this.txtBuscarCita.Size = new System.Drawing.Size(447, 39);
            this.txtBuscarCita.TabIndex = 22;
            // 
            // btnEditarCitas
            // 
            this.btnEditarCitas.BorderRadius = 10;
            this.btnEditarCitas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarCitas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarCitas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarCitas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarCitas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEditarCitas.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCitas.ForeColor = System.Drawing.Color.White;
            this.btnEditarCitas.Location = new System.Drawing.Point(377, 173);
            this.btnEditarCitas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarCitas.Name = "btnEditarCitas";
            this.btnEditarCitas.Size = new System.Drawing.Size(147, 57);
            this.btnEditarCitas.TabIndex = 27;
            this.btnEditarCitas.Text = "Editar";
            this.btnEditarCitas.Click += new System.EventHandler(this.btnEditarCitas_Click);
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
            // btnNuevoCita
            // 
            this.btnNuevoCita.BorderRadius = 10;
            this.btnNuevoCita.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoCita.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoCita.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevoCita.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevoCita.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(196)))), ((int)(((byte)(127)))));
            this.btnNuevoCita.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCita.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCita.Location = new System.Drawing.Point(157, 173);
            this.btnNuevoCita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevoCita.Name = "btnNuevoCita";
            this.btnNuevoCita.Size = new System.Drawing.Size(149, 57);
            this.btnNuevoCita.TabIndex = 26;
            this.btnNuevoCita.Text = "Nuevo";
            this.btnNuevoCita.Click += new System.EventHandler(this.btnNuevoCita_Click);
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
            this.label1.Text = "Gestion de Citas\r\n";
            // 
            // FrmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 621);
            this.Controls.Add(this.btnActualizarCita);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.btnEliminarCita);
            this.Controls.Add(this.txtBuscarCita);
            this.Controls.Add(this.btnEditarCitas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevoCita);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCitas";
            this.Text = "FrmCitas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnActualizarCita;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCitas;
        private Guna.UI2.WinForms.Guna2Button btnEliminarCita;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarCita;
        private Guna.UI2.WinForms.Guna2Button btnEditarCitas;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnNuevoCita;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
