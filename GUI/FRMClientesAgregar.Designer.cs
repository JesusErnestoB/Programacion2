
namespace GUI
{
    partial class FRMClientesAgregar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.lblIdClientes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtColoniaC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstadoC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMuniciopioC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocalidadC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCalleC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefonoC = new System.Windows.Forms.TextBox();
            this.lblNomProduct = new System.Windows.Forms.Label();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibEditar = new FontAwesome.Sharp.IconButton();
            this.ibGuardarClientes = new FontAwesome.Sharp.IconButton();
            this.ibCancelarClientes = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibtnInicio = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbuscarEspecificos = new System.Windows.Forms.TextBox();
            this.ibMostrar = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblidDomicilio = new System.Windows.Forms.Label();
            this.pnlClientes.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClientes
            // 
            this.pnlClientes.Controls.Add(this.lblidDomicilio);
            this.pnlClientes.Controls.Add(this.lblIdClientes);
            this.pnlClientes.Controls.Add(this.label7);
            this.pnlClientes.Controls.Add(this.txtColoniaC);
            this.pnlClientes.Controls.Add(this.label6);
            this.pnlClientes.Controls.Add(this.txtEstadoC);
            this.pnlClientes.Controls.Add(this.label5);
            this.pnlClientes.Controls.Add(this.txtMuniciopioC);
            this.pnlClientes.Controls.Add(this.label4);
            this.pnlClientes.Controls.Add(this.txtLocalidadC);
            this.pnlClientes.Controls.Add(this.label3);
            this.pnlClientes.Controls.Add(this.txtCalleC);
            this.pnlClientes.Controls.Add(this.label2);
            this.pnlClientes.Controls.Add(this.txtTelefonoC);
            this.pnlClientes.Controls.Add(this.lblNomProduct);
            this.pnlClientes.Controls.Add(this.txtNombreC);
            this.pnlClientes.Controls.Add(this.panel2);
            this.pnlClientes.Controls.Add(this.panel1);
            this.pnlClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClientes.Location = new System.Drawing.Point(0, 0);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(920, 357);
            this.pnlClientes.TabIndex = 1;
            this.pnlClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClientes_Paint);
            // 
            // lblIdClientes
            // 
            this.lblIdClientes.AutoSize = true;
            this.lblIdClientes.Location = new System.Drawing.Point(646, 115);
            this.lblIdClientes.Name = "lblIdClientes";
            this.lblIdClientes.Size = new System.Drawing.Size(52, 13);
            this.lblIdClientes.TabIndex = 76;
            this.lblIdClientes.Text = "id cliente ";
            this.lblIdClientes.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(61, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 75;
            this.label7.Text = "Colonia";
            // 
            // txtColoniaC
            // 
            this.txtColoniaC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtColoniaC.ForeColor = System.Drawing.Color.White;
            this.txtColoniaC.Location = new System.Drawing.Point(205, 306);
            this.txtColoniaC.Name = "txtColoniaC";
            this.txtColoniaC.Size = new System.Drawing.Size(158, 20);
            this.txtColoniaC.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(423, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Estado";
            // 
            // txtEstadoC
            // 
            this.txtEstadoC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtEstadoC.ForeColor = System.Drawing.Color.White;
            this.txtEstadoC.Location = new System.Drawing.Point(567, 258);
            this.txtEstadoC.Name = "txtEstadoC";
            this.txtEstadoC.Size = new System.Drawing.Size(158, 20);
            this.txtEstadoC.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(423, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Municipio";
            // 
            // txtMuniciopioC
            // 
            this.txtMuniciopioC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtMuniciopioC.ForeColor = System.Drawing.Color.White;
            this.txtMuniciopioC.Location = new System.Drawing.Point(567, 212);
            this.txtMuniciopioC.Name = "txtMuniciopioC";
            this.txtMuniciopioC.Size = new System.Drawing.Size(158, 20);
            this.txtMuniciopioC.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(423, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Localidad";
            // 
            // txtLocalidadC
            // 
            this.txtLocalidadC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtLocalidadC.ForeColor = System.Drawing.Color.White;
            this.txtLocalidadC.Location = new System.Drawing.Point(567, 168);
            this.txtLocalidadC.Name = "txtLocalidadC";
            this.txtLocalidadC.Size = new System.Drawing.Size(158, 20);
            this.txtLocalidadC.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(61, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Calle";
            // 
            // txtCalleC
            // 
            this.txtCalleC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCalleC.ForeColor = System.Drawing.Color.White;
            this.txtCalleC.Location = new System.Drawing.Point(205, 258);
            this.txtCalleC.Name = "txtCalleC";
            this.txtCalleC.Size = new System.Drawing.Size(158, 20);
            this.txtCalleC.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(61, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "No. Telefónico";
            // 
            // txtTelefonoC
            // 
            this.txtTelefonoC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtTelefonoC.ForeColor = System.Drawing.Color.White;
            this.txtTelefonoC.Location = new System.Drawing.Point(205, 212);
            this.txtTelefonoC.Name = "txtTelefonoC";
            this.txtTelefonoC.Size = new System.Drawing.Size(158, 20);
            this.txtTelefonoC.TabIndex = 64;
            // 
            // lblNomProduct
            // 
            this.lblNomProduct.AutoSize = true;
            this.lblNomProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomProduct.Location = new System.Drawing.Point(61, 168);
            this.lblNomProduct.Name = "lblNomProduct";
            this.lblNomProduct.Size = new System.Drawing.Size(72, 20);
            this.lblNomProduct.TabIndex = 63;
            this.lblNomProduct.Text = "Nombre ";
            // 
            // txtNombreC
            // 
            this.txtNombreC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombreC.ForeColor = System.Drawing.Color.White;
            this.txtNombreC.Location = new System.Drawing.Point(157, 170);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(206, 20);
            this.txtNombreC.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ibEditar);
            this.panel2.Controls.Add(this.ibGuardarClientes);
            this.panel2.Controls.Add(this.ibCancelarClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(727, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 257);
            this.panel2.TabIndex = 61;
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
            this.ibEditar.Location = new System.Drawing.Point(52, 184);
            this.ibEditar.Name = "ibEditar";
            this.ibEditar.Size = new System.Drawing.Size(88, 30);
            this.ibEditar.TabIndex = 49;
            this.ibEditar.Text = "Editar";
            this.ibEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibEditar.UseVisualStyleBackColor = true;
            this.ibEditar.Click += new System.EventHandler(this.ibEditar_Click);
            // 
            // ibGuardarClientes
            // 
            this.ibGuardarClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ibGuardarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ibGuardarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibGuardarClientes.ForeColor = System.Drawing.Color.White;
            this.ibGuardarClientes.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ibGuardarClientes.IconColor = System.Drawing.Color.White;
            this.ibGuardarClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibGuardarClientes.IconSize = 30;
            this.ibGuardarClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibGuardarClientes.Location = new System.Drawing.Point(52, 15);
            this.ibGuardarClientes.Name = "ibGuardarClientes";
            this.ibGuardarClientes.Size = new System.Drawing.Size(78, 47);
            this.ibGuardarClientes.TabIndex = 58;
            this.ibGuardarClientes.Text = "Guardar";
            this.ibGuardarClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibGuardarClientes.UseVisualStyleBackColor = true;
            this.ibGuardarClientes.Click += new System.EventHandler(this.ibGuardarClientes_Click);
            // 
            // ibCancelarClientes
            // 
            this.ibCancelarClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ibCancelarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ibCancelarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibCancelarClientes.ForeColor = System.Drawing.Color.White;
            this.ibCancelarClientes.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.ibCancelarClientes.IconColor = System.Drawing.Color.White;
            this.ibCancelarClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibCancelarClientes.IconSize = 30;
            this.ibCancelarClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibCancelarClientes.Location = new System.Drawing.Point(52, 101);
            this.ibCancelarClientes.Name = "ibCancelarClientes";
            this.ibCancelarClientes.Size = new System.Drawing.Size(78, 45);
            this.ibCancelarClientes.TabIndex = 59;
            this.ibCancelarClientes.Text = "Cancelar";
            this.ibCancelarClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibCancelarClientes.UseVisualStyleBackColor = true;
            this.ibCancelarClientes.Click += new System.EventHandler(this.ibCancelarClientes_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ibtnInicio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 100);
            this.panel1.TabIndex = 46;
            // 
            // ibtnInicio
            // 
            this.ibtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ibtnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtnInicio.IconColor = System.Drawing.Color.White;
            this.ibtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnInicio.Location = new System.Drawing.Point(47, 26);
            this.ibtnInicio.Name = "ibtnInicio";
            this.ibtnInicio.Size = new System.Drawing.Size(32, 32);
            this.ibtnInicio.TabIndex = 68;
            this.ibtnInicio.TabStop = false;
            this.ibtnInicio.Click += new System.EventHandler(this.ibtnInicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(406, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "Registrar Clientes";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(920, 231);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbuscarEspecificos);
            this.groupBox1.Controls.Add(this.ibMostrar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dgvClientes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 231);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // txtbuscarEspecificos
            // 
            this.txtbuscarEspecificos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.txtbuscarEspecificos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarEspecificos.ForeColor = System.Drawing.Color.White;
            this.txtbuscarEspecificos.Location = new System.Drawing.Point(120, 34);
            this.txtbuscarEspecificos.Name = "txtbuscarEspecificos";
            this.txtbuscarEspecificos.Size = new System.Drawing.Size(148, 26);
            this.txtbuscarEspecificos.TabIndex = 47;
            this.txtbuscarEspecificos.TextChanged += new System.EventHandler(this.txtbuscarEspecificos_TextChanged);
            // 
            // ibMostrar
            // 
            this.ibMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ibMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibMostrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ibMostrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibMostrar.IconColor = System.Drawing.Color.Black;
            this.ibMostrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibMostrar.Location = new System.Drawing.Point(309, 37);
            this.ibMostrar.Name = "ibMostrar";
            this.ibMostrar.Size = new System.Drawing.Size(133, 23);
            this.ibMostrar.TabIndex = 66;
            this.ibMostrar.Text = "Mostrar Todo";
            this.ibMostrar.UseVisualStyleBackColor = false;
            this.ibMostrar.Click += new System.EventHandler(this.ibMostrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 46;
            this.label8.Text = "Nombre";
            // 
            // dgvClientes
            // 
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.White;
            this.dgvClientes.Location = new System.Drawing.Point(27, 81);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(1606, 308);
            this.dgvClientes.TabIndex = 49;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // lblidDomicilio
            // 
            this.lblidDomicilio.AutoSize = true;
            this.lblidDomicilio.Location = new System.Drawing.Point(649, 132);
            this.lblidDomicilio.Name = "lblidDomicilio";
            this.lblidDomicilio.Size = new System.Drawing.Size(35, 13);
            this.lblidDomicilio.TabIndex = 77;
            this.lblidDomicilio.Text = "label9";
            // 
            // FRMClientesAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(920, 585);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMClientesAgregar";
            this.Text = "FRMClientesAgregar";
            this.pnlClientes.ResumeLayout(false);
            this.pnlClientes.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtColoniaC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEstadoC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMuniciopioC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLocalidadC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCalleC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefonoC;
        private System.Windows.Forms.Label lblNomProduct;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton ibGuardarClientes;
        private FontAwesome.Sharp.IconButton ibCancelarClientes;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox ibtnInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton ibEditar;
        private System.Windows.Forms.TextBox txtbuscarEspecificos;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton ibMostrar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblIdClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblidDomicilio;
    }
}