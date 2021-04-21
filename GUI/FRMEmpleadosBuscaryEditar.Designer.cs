
namespace GUI
{
    partial class FRMEmpleadosBuscaryEditar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibEditar = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibBuscarProd = new FontAwesome.Sharp.IconButton();
            this.lblNomProduct = new System.Windows.Forms.Label();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibtnInicio = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ibEditar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.ibBuscarProd);
            this.panel1.Controls.Add(this.lblNomProduct);
            this.panel1.Controls.Add(this.txtNombreE);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 480);
            this.panel1.TabIndex = 1;
            // 
            // ibEditar
            // 
            this.ibEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibEditar.ForeColor = System.Drawing.Color.Transparent;
            this.ibEditar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.ibEditar.IconColor = System.Drawing.Color.White;
            this.ibEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibEditar.IconSize = 25;
            this.ibEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibEditar.Location = new System.Drawing.Point(652, 98);
            this.ibEditar.Name = "ibEditar";
            this.ibEditar.Size = new System.Drawing.Size(88, 30);
            this.ibEditar.TabIndex = 58;
            this.ibEditar.Text = "Editar";
            this.ibEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibEditar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreC,
            this.calle,
            this.ApellidoP,
            this.ApellidoMat,
            this.edad,
            this.Sexo,
            this.Usuario,
            this.Colonia,
            this.localidad,
            this.Municipio,
            this.Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(919, 151);
            this.dataGridView1.TabIndex = 57;
            // 
            // NombreC
            // 
            this.NombreC.Frozen = true;
            this.NombreC.HeaderText = "Nombre";
            this.NombreC.Name = "NombreC";
            // 
            // calle
            // 
            this.calle.Frozen = true;
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            // 
            // ApellidoP
            // 
            this.ApellidoP.Frozen = true;
            this.ApellidoP.HeaderText = "Apellido Praterno";
            this.ApellidoP.Name = "ApellidoP";
            // 
            // ApellidoMat
            // 
            this.ApellidoMat.Frozen = true;
            this.ApellidoMat.HeaderText = "Apellido Materno";
            this.ApellidoMat.Name = "ApellidoMat";
            // 
            // edad
            // 
            this.edad.Frozen = true;
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            // 
            // Sexo
            // 
            this.Sexo.Frozen = true;
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Usuario
            // 
            this.Usuario.Frozen = true;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Colonia
            // 
            this.Colonia.Frozen = true;
            this.Colonia.HeaderText = "Colonia";
            this.Colonia.Name = "Colonia";
            // 
            // localidad
            // 
            this.localidad.Frozen = true;
            this.localidad.HeaderText = "Localidad";
            this.localidad.Name = "localidad";
            // 
            // Municipio
            // 
            this.Municipio.Frozen = true;
            this.Municipio.HeaderText = "Municipio";
            this.Municipio.Name = "Municipio";
            // 
            // Estado
            // 
            this.Estado.Frozen = true;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // ibBuscarProd
            // 
            this.ibBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibBuscarProd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibBuscarProd.ForeColor = System.Drawing.Color.Transparent;
            this.ibBuscarProd.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibBuscarProd.IconColor = System.Drawing.Color.White;
            this.ibBuscarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibBuscarProd.IconSize = 25;
            this.ibBuscarProd.Location = new System.Drawing.Point(492, 98);
            this.ibBuscarProd.Name = "ibBuscarProd";
            this.ibBuscarProd.Size = new System.Drawing.Size(30, 30);
            this.ibBuscarProd.TabIndex = 56;
            this.ibBuscarProd.UseVisualStyleBackColor = true;
            // 
            // lblNomProduct
            // 
            this.lblNomProduct.AutoSize = true;
            this.lblNomProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomProduct.Location = new System.Drawing.Point(169, 107);
            this.lblNomProduct.Name = "lblNomProduct";
            this.lblNomProduct.Size = new System.Drawing.Size(72, 20);
            this.lblNomProduct.TabIndex = 55;
            this.lblNomProduct.Text = "Nombre ";
            // 
            // txtNombreE
            // 
            this.txtNombreE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombreE.ForeColor = System.Drawing.Color.White;
            this.txtNombreE.Location = new System.Drawing.Point(249, 105);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(206, 20);
            this.txtNombreE.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ibtnInicio);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 75);
            this.panel2.TabIndex = 48;
            // 
            // ibtnInicio
            // 
            this.ibtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ibtnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtnInicio.IconColor = System.Drawing.Color.White;
            this.ibtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnInicio.Location = new System.Drawing.Point(36, 22);
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
            this.label1.Size = new System.Drawing.Size(176, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "Buscar Empleados";
            // 
            // FRMEmpleadosBuscaryEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(943, 480);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMEmpleadosBuscaryEditar";
            this.Text = "FRMEmpleadosBuscaryEditar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ibEditar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconButton ibBuscarProd;
        private System.Windows.Forms.Label lblNomProduct;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox ibtnInicio;
        private System.Windows.Forms.Label label1;
    }
}