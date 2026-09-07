namespace vistaa.DashboardAdmin
{
    partial class FrmDashboardAdministrador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlSalida = new System.Windows.Forms.Panel();
            this.btnSesion = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnVerCitas = new System.Windows.Forms.Button();
            this.btnMantenimientos = new System.Windows.Forms.Button();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnAgentes = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnpropi = new System.Windows.Forms.Button();
            this.pnlIcono = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuevo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.dgvClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlMenu.SuspendLayout();
            this.pnlSalida.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            this.pnlIcono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.AutoScrollMargin = new System.Drawing.Size(50, 1000);
            this.pnlMenu.AutoScrollMinSize = new System.Drawing.Size(5, 10);
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(147)))), ((int)(((byte)(111)))));
            this.pnlMenu.Controls.Add(this.pnlSalida);
            this.pnlMenu.Controls.Add(this.pnlConsulta);
            this.pnlMenu.Controls.Add(this.pnlIcono);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(307, 955);
            this.pnlMenu.TabIndex = 4;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // pnlSalida
            // 
            this.pnlSalida.Controls.Add(this.btnSesion);
            this.pnlSalida.Controls.Add(this.button3);
            this.pnlSalida.Controls.Add(this.btnMantenimientos);
            this.pnlSalida.Controls.Add(this.btnVerCitas);
            this.pnlSalida.Controls.Add(this.btnPagos);
            this.pnlSalida.Controls.Add(this.btnUsuarios);
            this.pnlSalida.Controls.Add(this.button4);
            this.pnlSalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSalida.Location = new System.Drawing.Point(0, 429);
            this.pnlSalida.Name = "pnlSalida";
            this.pnlSalida.Size = new System.Drawing.Size(281, 558);
            this.pnlSalida.TabIndex = 16;
            this.pnlSalida.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSalida_Paint);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(26, 147, 111);
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(281, 60);
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.FromArgb(26, 147, 111);
            this.btnPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPagos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(281, 60);
            this.btnPagos.Text = "Pagos";
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // btnVerCitas
            // 
            this.btnVerCitas.BackColor = System.Drawing.Color.FromArgb(26, 147, 111);
            this.btnVerCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerCitas.FlatAppearance.BorderSize = 0;
            this.btnVerCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnVerCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCitas.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnVerCitas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVerCitas.Name = "btnVerCitas";
            this.btnVerCitas.Size = new System.Drawing.Size(281, 60);
            this.btnVerCitas.Text = "Citas";
            this.btnVerCitas.UseVisualStyleBackColor = false;
            this.btnVerCitas.Click += new System.EventHandler(this.btnVerCitas_Click);
            // btnMantenimientos
            // 
            this.btnMantenimientos.BackColor = System.Drawing.Color.FromArgb(26, 147, 111);
            this.btnMantenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimientos.FlatAppearance.BorderSize = 0;
            this.btnMantenimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnMantenimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientos.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnMantenimientos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMantenimientos.Name = "btnMantenimientos";
            this.btnMantenimientos.Size = new System.Drawing.Size(281, 60);
            this.btnMantenimientos.Text = "Mantenimientos";
            this.btnMantenimientos.UseVisualStyleBackColor = false;
            this.btnMantenimientos.Click += new System.EventHandler(this.btnMantenimientos_Click);
            // btnSesion
            // 
            this.btnSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(147)))), ((int)(((byte)(111)))));
            this.btnSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSesion.FlatAppearance.BorderSize = 0;
            this.btnSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(147)))), ((int)(((byte)(111)))));
            this.btnSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesion.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSesion.Location = new System.Drawing.Point(0, 144);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(281, 60);
            this.btnSesion.TabIndex = 12;
            this.btnSesion.Text = "Cerrar Sesion";
            this.btnSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSesion.UseVisualStyleBackColor = false;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(147)))), ((int)(((byte)(111)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(147)))), ((int)(((byte)(111)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(0, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(281, 72);
            this.button3.TabIndex = 13;
            this.button3.Text = "Configuracion";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(147)))), ((int)(((byte)(111)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(147)))), ((int)(((byte)(111)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(281, 72);
            this.button4.TabIndex = 14;
            this.button4.Text = "Alquiler\r\n";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.Controls.Add(this.btnPerfil);
            this.pnlConsulta.Controls.Add(this.btnAgentes);
            this.pnlConsulta.Controls.Add(this.btnClientes);
            this.pnlConsulta.Controls.Add(this.btnpropi);
            this.pnlConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConsulta.Location = new System.Drawing.Point(0, 123);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(281, 306);
            this.pnlConsulta.TabIndex = 10;
            this.pnlConsulta.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlConsulta_Paint);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(147)))), ((int)(((byte)(111)))));
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPerfil.Location = new System.Drawing.Point(0, 246);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(281, 60);
            this.btnPerfil.TabIndex = 17;
            this.btnPerfil.Text = "Ventas";
            this.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnAgentes
            // 
            this.btnAgentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(147)))), ((int)(((byte)(111)))));
            this.btnAgentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgentes.FlatAppearance.BorderSize = 0;
            this.btnAgentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(147)))), ((int)(((byte)(111)))));
            this.btnAgentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnAgentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgentes.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgentes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgentes.Location = new System.Drawing.Point(0, 174);
            this.btnAgentes.Name = "btnAgentes";
            this.btnAgentes.Size = new System.Drawing.Size(281, 72);
            this.btnAgentes.TabIndex = 9;
            this.btnAgentes.Text = "Agentes\r\n";
            this.btnAgentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgentes.UseVisualStyleBackColor = false;
            this.btnAgentes.Click += new System.EventHandler(this.btnContratos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(147)))), ((int)(((byte)(111)))));
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(147)))), ((int)(((byte)(111)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClientes.Location = new System.Drawing.Point(0, 102);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(281, 72);
            this.btnClientes.TabIndex = 7;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnpropi
            // 
            this.btnpropi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(147)))), ((int)(((byte)(111)))));
            this.btnpropi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpropi.FlatAppearance.BorderSize = 0;
            this.btnpropi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(147)))), ((int)(((byte)(111)))));
            this.btnpropi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnpropi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpropi.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpropi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnpropi.Location = new System.Drawing.Point(0, 0);
            this.btnpropi.Name = "btnpropi";
            this.btnpropi.Size = new System.Drawing.Size(281, 102);
            this.btnpropi.TabIndex = 18;
            this.btnpropi.Text = "Propiedades\r\n";
            this.btnpropi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpropi.UseVisualStyleBackColor = false;
            this.btnpropi.Click += new System.EventHandler(this.btnMispropi_Click);
            // 
            // pnlIcono
            // 
            this.pnlIcono.Controls.Add(this.pictureBox1);
            this.pnlIcono.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIcono.Location = new System.Drawing.Point(0, 0);
            this.pnlIcono.Name = "pnlIcono";
            this.pnlIcono.Size = new System.Drawing.Size(281, 123);
            this.pnlIcono.TabIndex = 1;
            this.pnlIcono.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIcono_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::vistaa.Properties.Resources.agreement__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderRadius = 10;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Location = new System.Drawing.Point(81, 227);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Buscar por Nombre , DUI o Telefono";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(670, 60);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            this.btnBuscar.Location = new System.Drawing.Point(801, 227);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(204, 60);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BorderRadius = 10;
            this.btnNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(196)))), ((int)(((byte)(127)))));
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(468, 329);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(204, 60);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BorderRadius = 10;
            this.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(762, 329);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(204, 60);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(1059, 329);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(204, 60);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 10;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(1354, 329);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(204, 60);
            this.guna2Button4.TabIndex = 12;
            this.guna2Button4.Text = "Actualizar";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeight = 4;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClientes.Location = new System.Drawing.Point(39, 445);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 62;
            this.dgvClientes.RowTemplate.Height = 28;
            this.dgvClientes.Size = new System.Drawing.Size(1476, 443);
            this.dgvClientes.TabIndex = 13;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientes.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvClientes.ThemeStyle.ReadOnly = true;
            this.dgvClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientes.ThemeStyle.RowsStyle.Height = 28;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.dgvClientes);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(327, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1569, 908);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1395, 179);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(757, 74);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bienvenido Administrador\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(61, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(883, 40);
            this.label2.TabIndex = 15;
            this.label2.Text = "Administra y consulta la informacion de los clientes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(20, 36);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(507, 76);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Gestion de Clientes\r\n";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(20, 129);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(901, 47);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Administra y consulta la informacion de los clientes registrados\r\n";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // FrmDashboardAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1896, 955);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDashboardAdministrador";
            this.Text = "FrmDashboardAdministrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDashboardAdministrador_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlSalida.ResumeLayout(false);
            this.pnlConsulta.ResumeLayout(false);
            this.pnlIcono.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlSalida;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnAgentes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnpropi;
        private System.Windows.Forms.Panel pnlIcono;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnNuevo;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClientes;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnVerCitas;
        private System.Windows.Forms.Button btnMantenimientos;
    }
}
