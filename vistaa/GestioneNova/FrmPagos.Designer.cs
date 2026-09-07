namespace vistaa.GestioneNova
{
    partial class FrmPagos
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
            this.btnActualizarPago = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPagos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEliminarPago = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarPago = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditarPagos = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuevoPago = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizarPago
            // 
            this.btnActualizarPago.BorderRadius = 10;
            this.btnActualizarPago.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarPago.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarPago.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizarPago.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizarPago.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnActualizarPago.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnActualizarPago.ForeColor = System.Drawing.Color.White;
            this.btnActualizarPago.Location = new System.Drawing.Point(839, 173);
            this.btnActualizarPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarPago.Name = "btnActualizarPago";
            this.btnActualizarPago.Size = new System.Drawing.Size(153, 57);
            this.btnActualizarPago.TabIndex = 29;
            this.btnActualizarPago.Text = "Recargar";
            this.btnActualizarPago.Click += new System.EventHandler(this.btnActualizarPago_Click);
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPagos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagos.ColumnHeadersHeight = 40;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagos.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPagos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPagos.Location = new System.Drawing.Point(20, 245);
            this.dgvPagos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPagos.MultiSelect = false;
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.RowHeadersVisible = false;
            this.dgvPagos.RowHeadersWidth = 62;
            this.dgvPagos.RowTemplate.Height = 28;
            this.dgvPagos.Size = new System.Drawing.Size(1224, 365);
            this.dgvPagos.TabIndex = 24;
            this.dgvPagos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPagos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPagos.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvPagos.ThemeStyle.ReadOnly = true;
            this.dgvPagos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPagos.ThemeStyle.RowsStyle.Height = 28;
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.BorderRadius = 10;
            this.btnEliminarPago.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPago.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPago.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarPago.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarPago.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminarPago.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPago.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPago.Location = new System.Drawing.Point(616, 173);
            this.btnEliminarPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(145, 57);
            this.btnEliminarPago.TabIndex = 28;
            this.btnEliminarPago.Text = "Eliminar";
            this.btnEliminarPago.Click += new System.EventHandler(this.btnEliminarPago_Click);
            // 
            // txtBuscarPago
            // 
            this.txtBuscarPago.BorderRadius = 10;
            this.txtBuscarPago.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarPago.DefaultText = "Buscar pago";
            this.txtBuscarPago.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarPago.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarPago.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarPago.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarPago.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarPago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarPago.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarPago.Location = new System.Drawing.Point(231, 112);
            this.txtBuscarPago.Name = "txtBuscarPago";
            this.txtBuscarPago.PlaceholderText = "Buscar por metodo o estado";
            this.txtBuscarPago.SelectedText = "";
            this.txtBuscarPago.Size = new System.Drawing.Size(447, 39);
            this.txtBuscarPago.TabIndex = 22;
            // 
            // btnEditarPagos
            // 
            this.btnEditarPagos.BorderRadius = 10;
            this.btnEditarPagos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarPagos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarPagos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarPagos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarPagos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEditarPagos.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPagos.ForeColor = System.Drawing.Color.White;
            this.btnEditarPagos.Location = new System.Drawing.Point(377, 173);
            this.btnEditarPagos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarPagos.Name = "btnEditarPagos";
            this.btnEditarPagos.Size = new System.Drawing.Size(147, 57);
            this.btnEditarPagos.TabIndex = 27;
            this.btnEditarPagos.Text = "Editar";
            this.btnEditarPagos.Click += new System.EventHandler(this.btnEditarPagos_Click);
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
            // btnNuevoPago
            // 
            this.btnNuevoPago.BorderRadius = 10;
            this.btnNuevoPago.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoPago.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoPago.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevoPago.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevoPago.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(196)))), ((int)(((byte)(127)))));
            this.btnNuevoPago.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPago.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPago.Location = new System.Drawing.Point(157, 173);
            this.btnNuevoPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevoPago.Name = "btnNuevoPago";
            this.btnNuevoPago.Size = new System.Drawing.Size(149, 57);
            this.btnNuevoPago.TabIndex = 26;
            this.btnNuevoPago.Text = "Nuevo";
            this.btnNuevoPago.Click += new System.EventHandler(this.btnNuevoPago_Click);
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
            this.label1.Text = "Gestion de Pagos\r\n";
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 621);
            this.Controls.Add(this.btnActualizarPago);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.btnEliminarPago);
            this.Controls.Add(this.txtBuscarPago);
            this.Controls.Add(this.btnEditarPagos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevoPago);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPagos";
            this.Text = "FrmPagos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnActualizarPago;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPagos;
        private Guna.UI2.WinForms.Guna2Button btnEliminarPago;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarPago;
        private Guna.UI2.WinForms.Guna2Button btnEditarPagos;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnNuevoPago;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
