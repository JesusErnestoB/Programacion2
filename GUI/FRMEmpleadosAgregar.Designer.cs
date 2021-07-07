﻿
namespace GUI
{
    partial class FRMEmpleadosAgregar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Busqueda = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.ibMostrar = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.pnldatos = new System.Windows.Forms.Panel();
            this.lblidDomicilio = new System.Windows.Forms.Label();
            this.lblidempleados = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtColoniaE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.txtEstadoE = new System.Windows.Forms.TextBox();
            this.lblNomProduct = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.txtMuniciopioE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtLocalidadE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtCalleE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ibEditar = new FontAwesome.Sharp.IconButton();
            this.ibCancelar = new FontAwesome.Sharp.IconButton();
            this.ibGuardar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibtnInicio = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.pnldatos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pnldatos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 614);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Busqueda);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 325);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(803, 277);
            this.panel4.TabIndex = 100;
            // 
            // Busqueda
            // 
            this.Busqueda.Controls.Add(this.txtBuscar);
            this.Busqueda.Controls.Add(this.ibMostrar);
            this.Busqueda.Controls.Add(this.label11);
            this.Busqueda.Controls.Add(this.dgvEmpleados);
            this.Busqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Busqueda.ForeColor = System.Drawing.Color.White;
            this.Busqueda.Location = new System.Drawing.Point(0, 0);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(803, 277);
            this.Busqueda.TabIndex = 68;
            this.Busqueda.TabStop = false;
            this.Busqueda.Text = "Busacar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(171, 28);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(206, 20);
            this.txtBuscar.TabIndex = 59;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ibMostrar
            // 
            this.ibMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ibMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibMostrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ibMostrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibMostrar.IconColor = System.Drawing.Color.Black;
            this.ibMostrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibMostrar.Location = new System.Drawing.Point(444, 30);
            this.ibMostrar.Name = "ibMostrar";
            this.ibMostrar.Size = new System.Drawing.Size(133, 23);
            this.ibMostrar.TabIndex = 67;
            this.ibMostrar.Text = "Mostrar Todo";
            this.ibMostrar.UseVisualStyleBackColor = false;
            this.ibMostrar.Click += new System.EventHandler(this.ibMostrar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(91, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 60;
            this.label11.Text = "Nombre ";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleados.EnableHeadersVisualStyles = false;
            this.dgvEmpleados.GridColor = System.Drawing.Color.White;
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 59);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(785, 180);
            this.dgvEmpleados.TabIndex = 62;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // pnldatos
            // 
            this.pnldatos.Controls.Add(this.lblidDomicilio);
            this.pnldatos.Controls.Add(this.lblidempleados);
            this.pnldatos.Controls.Add(this.label7);
            this.pnldatos.Controls.Add(this.txtColoniaE);
            this.pnldatos.Controls.Add(this.label6);
            this.pnldatos.Controls.Add(this.txtNombreE);
            this.pnldatos.Controls.Add(this.txtEstadoE);
            this.pnldatos.Controls.Add(this.lblNomProduct);
            this.pnldatos.Controls.Add(this.label8);
            this.pnldatos.Controls.Add(this.txtApPaterno);
            this.pnldatos.Controls.Add(this.txtMuniciopioE);
            this.pnldatos.Controls.Add(this.label2);
            this.pnldatos.Controls.Add(this.label9);
            this.pnldatos.Controls.Add(this.txtApMaterno);
            this.pnldatos.Controls.Add(this.txtLocalidadE);
            this.pnldatos.Controls.Add(this.label3);
            this.pnldatos.Controls.Add(this.label10);
            this.pnldatos.Controls.Add(this.txtEdad);
            this.pnldatos.Controls.Add(this.txtCalleE);
            this.pnldatos.Controls.Add(this.label4);
            this.pnldatos.Controls.Add(this.label5);
            this.pnldatos.Controls.Add(this.txtSexo);
            this.pnldatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnldatos.Location = new System.Drawing.Point(0, 100);
            this.pnldatos.Name = "pnldatos";
            this.pnldatos.Size = new System.Drawing.Size(803, 225);
            this.pnldatos.TabIndex = 99;
            // 
            // lblidDomicilio
            // 
            this.lblidDomicilio.AutoSize = true;
            this.lblidDomicilio.Location = new System.Drawing.Point(756, 65);
            this.lblidDomicilio.Name = "lblidDomicilio";
            this.lblidDomicilio.Size = new System.Drawing.Size(41, 13);
            this.lblidDomicilio.TabIndex = 99;
            this.lblidDomicilio.Text = "label13";
            this.lblidDomicilio.Visible = false;
            // 
            // lblidempleados
            // 
            this.lblidempleados.AutoSize = true;
            this.lblidempleados.Location = new System.Drawing.Point(753, 26);
            this.lblidempleados.Name = "lblidempleados";
            this.lblidempleados.Size = new System.Drawing.Size(41, 13);
            this.lblidempleados.TabIndex = 98;
            this.lblidempleados.Text = "label12";
            this.lblidempleados.Visible = false;
            this.lblidempleados.Click += new System.EventHandler(this.lblidempleados_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(459, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "Colonia";
            // 
            // txtColoniaE
            // 
            this.txtColoniaE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtColoniaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtColoniaE.ForeColor = System.Drawing.Color.White;
            this.txtColoniaE.Location = new System.Drawing.Point(551, 55);
            this.txtColoniaE.Name = "txtColoniaE";
            this.txtColoniaE.Size = new System.Drawing.Size(158, 20);
            this.txtColoniaE.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(467, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 95;
            this.label6.Text = "Estado";
            // 
            // txtNombreE
            // 
            this.txtNombreE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNombreE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombreE.ForeColor = System.Drawing.Color.White;
            this.txtNombreE.Location = new System.Drawing.Point(184, 16);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(206, 20);
            this.txtNombreE.TabIndex = 78;
            // 
            // txtEstadoE
            // 
            this.txtEstadoE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEstadoE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtEstadoE.ForeColor = System.Drawing.Color.White;
            this.txtEstadoE.Location = new System.Drawing.Point(551, 190);
            this.txtEstadoE.Name = "txtEstadoE";
            this.txtEstadoE.Size = new System.Drawing.Size(158, 20);
            this.txtEstadoE.TabIndex = 94;
            // 
            // lblNomProduct
            // 
            this.lblNomProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNomProduct.AutoSize = true;
            this.lblNomProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomProduct.Location = new System.Drawing.Point(104, 18);
            this.lblNomProduct.Name = "lblNomProduct";
            this.lblNomProduct.Size = new System.Drawing.Size(72, 20);
            this.lblNomProduct.TabIndex = 79;
            this.lblNomProduct.Text = "Nombre ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(444, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 93;
            this.label8.Text = "Municipio";
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtApPaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtApPaterno.ForeColor = System.Drawing.Color.White;
            this.txtApPaterno.Location = new System.Drawing.Point(184, 55);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(206, 20);
            this.txtApPaterno.TabIndex = 80;
            // 
            // txtMuniciopioE
            // 
            this.txtMuniciopioE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMuniciopioE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtMuniciopioE.ForeColor = System.Drawing.Color.White;
            this.txtMuniciopioE.Location = new System.Drawing.Point(551, 139);
            this.txtMuniciopioE.Name = "txtMuniciopioE";
            this.txtMuniciopioE.Size = new System.Drawing.Size(158, 20);
            this.txtMuniciopioE.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(41, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Apellido Paterno ";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(443, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 91;
            this.label9.Text = "Localidad";
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtApMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtApMaterno.ForeColor = System.Drawing.Color.White;
            this.txtApMaterno.Location = new System.Drawing.Point(184, 97);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(206, 20);
            this.txtApMaterno.TabIndex = 82;
            // 
            // txtLocalidadE
            // 
            this.txtLocalidadE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLocalidadE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtLocalidadE.ForeColor = System.Drawing.Color.White;
            this.txtLocalidadE.Location = new System.Drawing.Point(551, 99);
            this.txtLocalidadE.Name = "txtLocalidadE";
            this.txtLocalidadE.Size = new System.Drawing.Size(158, 20);
            this.txtLocalidadE.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(39, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "Apellido Materno";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(477, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 89;
            this.label10.Text = "Calle";
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEdad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtEdad.ForeColor = System.Drawing.Color.White;
            this.txtEdad.Location = new System.Drawing.Point(184, 139);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(206, 20);
            this.txtEdad.TabIndex = 84;
            // 
            // txtCalleE
            // 
            this.txtCalleE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCalleE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCalleE.ForeColor = System.Drawing.Color.White;
            this.txtCalleE.Location = new System.Drawing.Point(551, 20);
            this.txtCalleE.Name = "txtCalleE";
            this.txtCalleE.Size = new System.Drawing.Size(158, 20);
            this.txtCalleE.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(129, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(133, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 87;
            this.label5.Text = "Sexo";
            // 
            // txtSexo
            // 
            this.txtSexo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtSexo.ForeColor = System.Drawing.Color.White;
            this.txtSexo.Location = new System.Drawing.Point(184, 190);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(206, 20);
            this.txtSexo.TabIndex = 86;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ibEditar);
            this.panel3.Controls.Add(this.ibCancelar);
            this.panel3.Controls.Add(this.ibGuardar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(803, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 514);
            this.panel3.TabIndex = 73;
            // 
            // ibEditar
            // 
            this.ibEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ibEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ibEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibEditar.ForeColor = System.Drawing.Color.Transparent;
            this.ibEditar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.ibEditar.IconColor = System.Drawing.Color.White;
            this.ibEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibEditar.IconSize = 25;
            this.ibEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibEditar.Location = new System.Drawing.Point(23, 178);
            this.ibEditar.Name = "ibEditar";
            this.ibEditar.Size = new System.Drawing.Size(88, 30);
            this.ibEditar.TabIndex = 63;
            this.ibEditar.Text = "Editar";
            this.ibEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibEditar.UseVisualStyleBackColor = true;
            this.ibEditar.Click += new System.EventHandler(this.ibEditar_Click);
            // 
            // ibCancelar
            // 
            this.ibCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ibCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ibCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibCancelar.ForeColor = System.Drawing.Color.White;
            this.ibCancelar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.ibCancelar.IconColor = System.Drawing.Color.White;
            this.ibCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibCancelar.IconSize = 30;
            this.ibCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibCancelar.Location = new System.Drawing.Point(30, 103);
            this.ibCancelar.Name = "ibCancelar";
            this.ibCancelar.Size = new System.Drawing.Size(76, 45);
            this.ibCancelar.TabIndex = 44;
            this.ibCancelar.Text = "Cancelar";
            this.ibCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibCancelar.UseVisualStyleBackColor = true;
            this.ibCancelar.Click += new System.EventHandler(this.ibCancelar_Click);
            // 
            // ibGuardar
            // 
            this.ibGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ibGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ibGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibGuardar.ForeColor = System.Drawing.Color.White;
            this.ibGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ibGuardar.IconColor = System.Drawing.Color.White;
            this.ibGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibGuardar.IconSize = 30;
            this.ibGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibGuardar.Location = new System.Drawing.Point(30, 32);
            this.ibGuardar.Name = "ibGuardar";
            this.ibGuardar.Size = new System.Drawing.Size(76, 47);
            this.ibGuardar.TabIndex = 43;
            this.ibGuardar.Text = "Guardar";
            this.ibGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibGuardar.UseVisualStyleBackColor = true;
            this.ibGuardar.Click += new System.EventHandler(this.ibGuardar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ibtnInicio);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 100);
            this.panel2.TabIndex = 47;
            // 
            // ibtnInicio
            // 
            this.ibtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ibtnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtnInicio.IconColor = System.Drawing.Color.White;
            this.ibtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnInicio.Location = new System.Drawing.Point(41, 32);
            this.ibtnInicio.Name = "ibtnInicio";
            this.ibtnInicio.Size = new System.Drawing.Size(32, 32);
            this.ibtnInicio.TabIndex = 69;
            this.ibtnInicio.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(363, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "Registro de empleados";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FRMEmpleadosAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(943, 614);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMEmpleadosAgregar";
            this.Text = "FRMEmpleadosAgregar";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.Busqueda.ResumeLayout(false);
            this.Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.pnldatos.ResumeLayout(false);
            this.pnldatos.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton ibCancelar;
        private FontAwesome.Sharp.IconButton ibGuardar;
        private System.Windows.Forms.TextBox txtColoniaE;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox ibtnInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.TextBox txtEstadoE;
        private System.Windows.Forms.Label lblNomProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.TextBox txtMuniciopioE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.TextBox txtLocalidadE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtCalleE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Panel pnldatos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBuscar;
        private FontAwesome.Sharp.IconButton ibEditar;
        private FontAwesome.Sharp.IconButton ibMostrar;
        private System.Windows.Forms.Label lblidempleados;
        private System.Windows.Forms.Label lblidDomicilio;
        private System.Windows.Forms.GroupBox Busqueda;
    }
}