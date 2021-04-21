
namespace GUI
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            this.Barra_Titulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.pnlReporte = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.ibReporte = new FontAwesome.Sharp.IconButton();
            this.pnlEmpleados = new System.Windows.Forms.Panel();
            this.ibBusacarEm = new FontAwesome.Sharp.IconButton();
            this.ibEditarEm = new FontAwesome.Sharp.IconButton();
            this.ibAgregarEm = new FontAwesome.Sharp.IconButton();
            this.ibEmpleados = new FontAwesome.Sharp.IconButton();
            this.pnlCompras = new System.Windows.Forms.Panel();
            this.ibRegistrar = new FontAwesome.Sharp.IconButton();
            this.ibCompras = new FontAwesome.Sharp.IconButton();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.ibBuscarC = new FontAwesome.Sharp.IconButton();
            this.ibEditarC = new FontAwesome.Sharp.IconButton();
            this.ibAgrarC = new FontAwesome.Sharp.IconButton();
            this.ibClientes = new FontAwesome.Sharp.IconButton();
            this.ibVentas = new FontAwesome.Sharp.IconButton();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.ibBuscarProd = new FontAwesome.Sharp.IconButton();
            this.ibEditarProd = new FontAwesome.Sharp.IconButton();
            this.ibAgreagarProducto = new FontAwesome.Sharp.IconButton();
            this.ibProductos = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.Barra_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlReporte.SuspendLayout();
            this.pnlEmpleados.SuspendLayout();
            this.pnlCompras.SuspendLayout();
            this.pnlClientes.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barra_Titulo
            // 
            this.Barra_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Barra_Titulo.Controls.Add(this.btnMaximizar);
            this.Barra_Titulo.Controls.Add(this.label1);
            this.Barra_Titulo.Controls.Add(this.btnRestaurar);
            this.Barra_Titulo.Controls.Add(this.btnMinimizar);
            this.Barra_Titulo.Controls.Add(this.btnCerrar);
            this.Barra_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Barra_Titulo.Name = "Barra_Titulo";
            this.Barra_Titulo.Size = new System.Drawing.Size(1135, 37);
            this.Barra_Titulo.TabIndex = 3;
            this.Barra_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_Titulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(222, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Papeleria \"Memo\"";
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1069, 10);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 20);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 4;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1069, 10);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1030, 10);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1106, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlMenu.Controls.Add(this.iconButton4);
            this.pnlMenu.Controls.Add(this.pnlReporte);
            this.pnlMenu.Controls.Add(this.ibReporte);
            this.pnlMenu.Controls.Add(this.pnlEmpleados);
            this.pnlMenu.Controls.Add(this.ibEmpleados);
            this.pnlMenu.Controls.Add(this.pnlCompras);
            this.pnlMenu.Controls.Add(this.ibCompras);
            this.pnlMenu.Controls.Add(this.pnlClientes);
            this.pnlMenu.Controls.Add(this.ibClientes);
            this.pnlMenu.Controls.Add(this.ibVentas);
            this.pnlMenu.Controls.Add(this.pnlProductos);
            this.pnlMenu.Controls.Add(this.ibProductos);
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 37);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 751);
            this.pnlMenu.TabIndex = 4;
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 695);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(220, 30);
            this.iconButton4.TabIndex = 36;
            this.iconButton4.Text = "Proveedor ";
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.ibProveedor_Click);
            // 
            // pnlReporte
            // 
            this.pnlReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pnlReporte.Controls.Add(this.iconButton1);
            this.pnlReporte.Controls.Add(this.iconButton2);
            this.pnlReporte.Controls.Add(this.iconButton3);
            this.pnlReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReporte.Location = new System.Drawing.Point(0, 594);
            this.pnlReporte.Name = "pnlReporte";
            this.pnlReporte.Size = new System.Drawing.Size(220, 101);
            this.pnlReporte.TabIndex = 35;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 60);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(220, 30);
            this.iconButton1.TabIndex = 28;
            this.iconButton1.Text = "Producto mas vendido";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 30);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(220, 30);
            this.iconButton2.TabIndex = 27;
            this.iconButton2.Text = "Reporte de compra ";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(220, 30);
            this.iconButton3.TabIndex = 26;
            this.iconButton3.Text = "Reporte de venta ";
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // ibReporte
            // 
            this.ibReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibReporte.ForeColor = System.Drawing.Color.Transparent;
            this.ibReporte.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.ibReporte.IconColor = System.Drawing.Color.White;
            this.ibReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibReporte.IconSize = 30;
            this.ibReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibReporte.Location = new System.Drawing.Point(0, 564);
            this.ibReporte.Name = "ibReporte";
            this.ibReporte.Size = new System.Drawing.Size(220, 30);
            this.ibReporte.TabIndex = 34;
            this.ibReporte.Text = "Reporte";
            this.ibReporte.UseVisualStyleBackColor = true;
            this.ibReporte.Click += new System.EventHandler(this.ibReporte_Click);
            // 
            // pnlEmpleados
            // 
            this.pnlEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pnlEmpleados.Controls.Add(this.ibBusacarEm);
            this.pnlEmpleados.Controls.Add(this.ibEditarEm);
            this.pnlEmpleados.Controls.Add(this.ibAgregarEm);
            this.pnlEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmpleados.Location = new System.Drawing.Point(0, 463);
            this.pnlEmpleados.Name = "pnlEmpleados";
            this.pnlEmpleados.Size = new System.Drawing.Size(220, 101);
            this.pnlEmpleados.TabIndex = 33;
            // 
            // ibBusacarEm
            // 
            this.ibBusacarEm.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibBusacarEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibBusacarEm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibBusacarEm.ForeColor = System.Drawing.Color.Transparent;
            this.ibBusacarEm.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibBusacarEm.IconColor = System.Drawing.Color.White;
            this.ibBusacarEm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibBusacarEm.IconSize = 25;
            this.ibBusacarEm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibBusacarEm.Location = new System.Drawing.Point(0, 60);
            this.ibBusacarEm.Name = "ibBusacarEm";
            this.ibBusacarEm.Size = new System.Drawing.Size(220, 30);
            this.ibBusacarEm.TabIndex = 28;
            this.ibBusacarEm.Text = "Buscar";
            this.ibBusacarEm.UseVisualStyleBackColor = true;
            this.ibBusacarEm.Click += new System.EventHandler(this.ibBusacarEm_Click);
            // 
            // ibEditarEm
            // 
            this.ibEditarEm.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibEditarEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibEditarEm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibEditarEm.ForeColor = System.Drawing.Color.Transparent;
            this.ibEditarEm.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.ibEditarEm.IconColor = System.Drawing.Color.White;
            this.ibEditarEm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibEditarEm.IconSize = 25;
            this.ibEditarEm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibEditarEm.Location = new System.Drawing.Point(0, 30);
            this.ibEditarEm.Name = "ibEditarEm";
            this.ibEditarEm.Size = new System.Drawing.Size(220, 30);
            this.ibEditarEm.TabIndex = 27;
            this.ibEditarEm.Text = "Editar";
            this.ibEditarEm.UseVisualStyleBackColor = true;
            this.ibEditarEm.Click += new System.EventHandler(this.ibEditarEm_Click);
            // 
            // ibAgregarEm
            // 
            this.ibAgregarEm.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibAgregarEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibAgregarEm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibAgregarEm.ForeColor = System.Drawing.Color.Transparent;
            this.ibAgregarEm.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.ibAgregarEm.IconColor = System.Drawing.Color.White;
            this.ibAgregarEm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAgregarEm.IconSize = 25;
            this.ibAgregarEm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAgregarEm.Location = new System.Drawing.Point(0, 0);
            this.ibAgregarEm.Name = "ibAgregarEm";
            this.ibAgregarEm.Size = new System.Drawing.Size(220, 30);
            this.ibAgregarEm.TabIndex = 26;
            this.ibAgregarEm.Text = "Agregar";
            this.ibAgregarEm.UseVisualStyleBackColor = true;
            this.ibAgregarEm.Click += new System.EventHandler(this.ibAgregarEm_Click);
            // 
            // ibEmpleados
            // 
            this.ibEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibEmpleados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibEmpleados.ForeColor = System.Drawing.Color.Transparent;
            this.ibEmpleados.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ibEmpleados.IconColor = System.Drawing.Color.White;
            this.ibEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibEmpleados.IconSize = 30;
            this.ibEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibEmpleados.Location = new System.Drawing.Point(0, 433);
            this.ibEmpleados.Name = "ibEmpleados";
            this.ibEmpleados.Size = new System.Drawing.Size(220, 30);
            this.ibEmpleados.TabIndex = 32;
            this.ibEmpleados.Text = "Empleados";
            this.ibEmpleados.UseVisualStyleBackColor = true;
            this.ibEmpleados.Click += new System.EventHandler(this.ibEmpleados_Click);
            // 
            // pnlCompras
            // 
            this.pnlCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pnlCompras.Controls.Add(this.ibRegistrar);
            this.pnlCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCompras.Location = new System.Drawing.Point(0, 394);
            this.pnlCompras.Name = "pnlCompras";
            this.pnlCompras.Size = new System.Drawing.Size(220, 39);
            this.pnlCompras.TabIndex = 31;
            // 
            // ibRegistrar
            // 
            this.ibRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibRegistrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibRegistrar.ForeColor = System.Drawing.Color.Transparent;
            this.ibRegistrar.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.ibRegistrar.IconColor = System.Drawing.Color.White;
            this.ibRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibRegistrar.IconSize = 25;
            this.ibRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibRegistrar.Location = new System.Drawing.Point(0, 0);
            this.ibRegistrar.Name = "ibRegistrar";
            this.ibRegistrar.Size = new System.Drawing.Size(220, 30);
            this.ibRegistrar.TabIndex = 26;
            this.ibRegistrar.Text = "Registrar";
            this.ibRegistrar.UseVisualStyleBackColor = true;
            this.ibRegistrar.Click += new System.EventHandler(this.ibRegistrar_Click);
            // 
            // ibCompras
            // 
            this.ibCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibCompras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibCompras.ForeColor = System.Drawing.Color.Transparent;
            this.ibCompras.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.ibCompras.IconColor = System.Drawing.Color.White;
            this.ibCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibCompras.IconSize = 30;
            this.ibCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibCompras.Location = new System.Drawing.Point(0, 364);
            this.ibCompras.Name = "ibCompras";
            this.ibCompras.Size = new System.Drawing.Size(220, 30);
            this.ibCompras.TabIndex = 30;
            this.ibCompras.Text = "Compras";
            this.ibCompras.UseVisualStyleBackColor = true;
            this.ibCompras.Click += new System.EventHandler(this.ibCompras_Click);
            // 
            // pnlClientes
            // 
            this.pnlClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pnlClientes.Controls.Add(this.ibBuscarC);
            this.pnlClientes.Controls.Add(this.ibEditarC);
            this.pnlClientes.Controls.Add(this.ibAgrarC);
            this.pnlClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClientes.Location = new System.Drawing.Point(0, 266);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(220, 98);
            this.pnlClientes.TabIndex = 29;
            // 
            // ibBuscarC
            // 
            this.ibBuscarC.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibBuscarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibBuscarC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibBuscarC.ForeColor = System.Drawing.Color.Transparent;
            this.ibBuscarC.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibBuscarC.IconColor = System.Drawing.Color.White;
            this.ibBuscarC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibBuscarC.IconSize = 25;
            this.ibBuscarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibBuscarC.Location = new System.Drawing.Point(0, 60);
            this.ibBuscarC.Name = "ibBuscarC";
            this.ibBuscarC.Size = new System.Drawing.Size(220, 30);
            this.ibBuscarC.TabIndex = 28;
            this.ibBuscarC.Text = "Buscar";
            this.ibBuscarC.UseVisualStyleBackColor = true;
            this.ibBuscarC.Click += new System.EventHandler(this.ibBuscarC_Click);
            // 
            // ibEditarC
            // 
            this.ibEditarC.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibEditarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibEditarC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibEditarC.ForeColor = System.Drawing.Color.Transparent;
            this.ibEditarC.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.ibEditarC.IconColor = System.Drawing.Color.White;
            this.ibEditarC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibEditarC.IconSize = 25;
            this.ibEditarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibEditarC.Location = new System.Drawing.Point(0, 30);
            this.ibEditarC.Name = "ibEditarC";
            this.ibEditarC.Size = new System.Drawing.Size(220, 30);
            this.ibEditarC.TabIndex = 27;
            this.ibEditarC.Text = "Editar";
            this.ibEditarC.UseVisualStyleBackColor = true;
            this.ibEditarC.Click += new System.EventHandler(this.ibEditarC_Click);
            // 
            // ibAgrarC
            // 
            this.ibAgrarC.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibAgrarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibAgrarC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibAgrarC.ForeColor = System.Drawing.Color.Transparent;
            this.ibAgrarC.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.ibAgrarC.IconColor = System.Drawing.Color.White;
            this.ibAgrarC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAgrarC.IconSize = 25;
            this.ibAgrarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAgrarC.Location = new System.Drawing.Point(0, 0);
            this.ibAgrarC.Name = "ibAgrarC";
            this.ibAgrarC.Size = new System.Drawing.Size(220, 30);
            this.ibAgrarC.TabIndex = 26;
            this.ibAgrarC.Text = "Agregar";
            this.ibAgrarC.UseVisualStyleBackColor = true;
            this.ibAgrarC.Click += new System.EventHandler(this.ibEditarC_Click);
            // 
            // ibClientes
            // 
            this.ibClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibClientes.ForeColor = System.Drawing.Color.Transparent;
            this.ibClientes.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.ibClientes.IconColor = System.Drawing.Color.White;
            this.ibClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibClientes.IconSize = 30;
            this.ibClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibClientes.Location = new System.Drawing.Point(0, 236);
            this.ibClientes.Name = "ibClientes";
            this.ibClientes.Size = new System.Drawing.Size(220, 30);
            this.ibClientes.TabIndex = 28;
            this.ibClientes.Text = "Clientes";
            this.ibClientes.UseVisualStyleBackColor = true;
            this.ibClientes.Click += new System.EventHandler(this.ibClientes_Click);
            // 
            // ibVentas
            // 
            this.ibVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibVentas.ForeColor = System.Drawing.Color.Transparent;
            this.ibVentas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.ibVentas.IconColor = System.Drawing.Color.White;
            this.ibVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibVentas.IconSize = 30;
            this.ibVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibVentas.Location = new System.Drawing.Point(0, 206);
            this.ibVentas.Name = "ibVentas";
            this.ibVentas.Size = new System.Drawing.Size(220, 30);
            this.ibVentas.TabIndex = 27;
            this.ibVentas.Text = "Ventas";
            this.ibVentas.UseVisualStyleBackColor = true;
            this.ibVentas.Click += new System.EventHandler(this.ibVentas_Click);
            // 
            // pnlProductos
            // 
            this.pnlProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pnlProductos.Controls.Add(this.ibBuscarProd);
            this.pnlProductos.Controls.Add(this.ibEditarProd);
            this.pnlProductos.Controls.Add(this.ibAgreagarProducto);
            this.pnlProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductos.Location = new System.Drawing.Point(0, 108);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(220, 98);
            this.pnlProductos.TabIndex = 26;
            // 
            // ibBuscarProd
            // 
            this.ibBuscarProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibBuscarProd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibBuscarProd.ForeColor = System.Drawing.Color.Transparent;
            this.ibBuscarProd.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibBuscarProd.IconColor = System.Drawing.Color.White;
            this.ibBuscarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibBuscarProd.IconSize = 25;
            this.ibBuscarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibBuscarProd.Location = new System.Drawing.Point(0, 60);
            this.ibBuscarProd.Name = "ibBuscarProd";
            this.ibBuscarProd.Size = new System.Drawing.Size(220, 30);
            this.ibBuscarProd.TabIndex = 28;
            this.ibBuscarProd.Text = "Buscar";
            this.ibBuscarProd.UseVisualStyleBackColor = true;
            this.ibBuscarProd.Click += new System.EventHandler(this.ibBuscarProd_Click);
            // 
            // ibEditarProd
            // 
            this.ibEditarProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibEditarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibEditarProd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibEditarProd.ForeColor = System.Drawing.Color.Transparent;
            this.ibEditarProd.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.ibEditarProd.IconColor = System.Drawing.Color.White;
            this.ibEditarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibEditarProd.IconSize = 25;
            this.ibEditarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibEditarProd.Location = new System.Drawing.Point(0, 30);
            this.ibEditarProd.Name = "ibEditarProd";
            this.ibEditarProd.Size = new System.Drawing.Size(220, 30);
            this.ibEditarProd.TabIndex = 27;
            this.ibEditarProd.Text = "Editar";
            this.ibEditarProd.UseVisualStyleBackColor = true;
            this.ibEditarProd.Click += new System.EventHandler(this.ibEditarProd_Click);
            // 
            // ibAgreagarProducto
            // 
            this.ibAgreagarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibAgreagarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibAgreagarProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibAgreagarProducto.ForeColor = System.Drawing.Color.Transparent;
            this.ibAgreagarProducto.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.ibAgreagarProducto.IconColor = System.Drawing.Color.White;
            this.ibAgreagarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAgreagarProducto.IconSize = 25;
            this.ibAgreagarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAgreagarProducto.Location = new System.Drawing.Point(0, 0);
            this.ibAgreagarProducto.Name = "ibAgreagarProducto";
            this.ibAgreagarProducto.Size = new System.Drawing.Size(220, 30);
            this.ibAgreagarProducto.TabIndex = 26;
            this.ibAgreagarProducto.Text = "Agregar";
            this.ibAgreagarProducto.UseVisualStyleBackColor = true;
            this.ibAgreagarProducto.Click += new System.EventHandler(this.ibAgreagarProducto_Click);
            // 
            // ibProductos
            // 
            this.ibProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibProductos.ForeColor = System.Drawing.Color.Transparent;
            this.ibProductos.IconChar = FontAwesome.Sharp.IconChar.Desktop;
            this.ibProductos.IconColor = System.Drawing.Color.White;
            this.ibProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibProductos.IconSize = 30;
            this.ibProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibProductos.Location = new System.Drawing.Point(0, 78);
            this.ibProductos.Name = "ibProductos";
            this.ibProductos.Size = new System.Drawing.Size(220, 30);
            this.ibProductos.TabIndex = 25;
            this.ibProductos.Text = "Productos";
            this.ibProductos.UseVisualStyleBackColor = true;
            this.ibProductos.Click += new System.EventHandler(this.ibProductos_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 78);
            this.panel3.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(226, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 424);
            this.panel1.TabIndex = 5;
            // 
            // pnlInicio
            // 
            this.pnlInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInicio.Location = new System.Drawing.Point(226, 46);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(943, 424);
            this.pnlInicio.TabIndex = 6;
            this.pnlInicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseDown);
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1135, 788);
            this.Controls.Add(this.pnlInicio);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.Barra_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaInicio";
            this.Text = "PantallaInicio";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_Titulo_MouseDown);
            this.Barra_Titulo.ResumeLayout(false);
            this.Barra_Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlReporte.ResumeLayout(false);
            this.pnlEmpleados.ResumeLayout(false);
            this.pnlCompras.ResumeLayout(false);
            this.pnlClientes.ResumeLayout(false);
            this.pnlProductos.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barra_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel pnlReporte;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton ibReporte;
        private System.Windows.Forms.Panel pnlEmpleados;
        private FontAwesome.Sharp.IconButton ibBusacarEm;
        private FontAwesome.Sharp.IconButton ibEditarEm;
        private FontAwesome.Sharp.IconButton ibAgregarEm;
        private FontAwesome.Sharp.IconButton ibEmpleados;
        private System.Windows.Forms.Panel pnlCompras;
        private FontAwesome.Sharp.IconButton ibRegistrar;
        private FontAwesome.Sharp.IconButton ibCompras;
        private System.Windows.Forms.Panel pnlClientes;
        private FontAwesome.Sharp.IconButton ibBuscarC;
        private FontAwesome.Sharp.IconButton ibEditarC;
        private FontAwesome.Sharp.IconButton ibAgrarC;
        private FontAwesome.Sharp.IconButton ibClientes;
        private FontAwesome.Sharp.IconButton ibVentas;
        private System.Windows.Forms.Panel pnlProductos;
        private FontAwesome.Sharp.IconButton ibBuscarProd;
        private FontAwesome.Sharp.IconButton ibEditarProd;
        private FontAwesome.Sharp.IconButton ibAgreagarProducto;
        private FontAwesome.Sharp.IconButton ibProductos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlInicio;
    }
}