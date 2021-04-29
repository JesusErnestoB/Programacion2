﻿
namespace GUI
{
    partial class FRMProductos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibtnInicio = new FontAwesome.Sharp.IconPictureBox();
            this.ibCancelar = new FontAwesome.Sharp.IconButton();
            this.ibGuardar = new FontAwesome.Sharp.IconButton();
            this.lblPrecioVentP = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioCompP = new System.Windows.Forms.Label();
            this.txtPrecioComp = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblDescripccionP = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCantidadP = new System.Windows.Forms.Label();
            this.lblMarcaP = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblColorP = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblCodigoproducto = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNomProduct = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.ibtnInicio);
            this.panel1.Controls.Add(this.ibCancelar);
            this.panel1.Controls.Add(this.ibGuardar);
            this.panel1.Controls.Add(this.lblPrecioVentP);
            this.panel1.Controls.Add(this.txtPrecioVenta);
            this.panel1.Controls.Add(this.lblPrecioCompP);
            this.panel1.Controls.Add(this.txtPrecioComp);
            this.panel1.Controls.Add(this.nudCantidad);
            this.panel1.Controls.Add(this.lblDescripccionP);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.lblCantidadP);
            this.panel1.Controls.Add(this.lblMarcaP);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.lblColorP);
            this.panel1.Controls.Add(this.txtColor);
            this.panel1.Controls.Add(this.lblCodigoproducto);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblNomProduct);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // ibtnInicio
            // 
            this.ibtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ibtnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtnInicio.IconColor = System.Drawing.Color.White;
            this.ibtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnInicio.Location = new System.Drawing.Point(33, 30);
            this.ibtnInicio.Name = "ibtnInicio";
            this.ibtnInicio.Size = new System.Drawing.Size(32, 32);
            this.ibtnInicio.TabIndex = 65;
            this.ibtnInicio.TabStop = false;
            this.ibtnInicio.Click += new System.EventHandler(this.ibtnInicio_Click);
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
            this.ibCancelar.Location = new System.Drawing.Point(575, 340);
            this.ibCancelar.Name = "ibCancelar";
            this.ibCancelar.Size = new System.Drawing.Size(78, 45);
            this.ibCancelar.TabIndex = 64;
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
            this.ibGuardar.Location = new System.Drawing.Point(575, 287);
            this.ibGuardar.Name = "ibGuardar";
            this.ibGuardar.Size = new System.Drawing.Size(78, 47);
            this.ibGuardar.TabIndex = 63;
            this.ibGuardar.Text = "Guardar";
            this.ibGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibGuardar.UseVisualStyleBackColor = true;
            this.ibGuardar.Click += new System.EventHandler(this.ibGuardar_Click);
            // 
            // lblPrecioVentP
            // 
            this.lblPrecioVentP.AutoSize = true;
            this.lblPrecioVentP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVentP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecioVentP.Location = new System.Drawing.Point(164, 259);
            this.lblPrecioVentP.Name = "lblPrecioVentP";
            this.lblPrecioVentP.Size = new System.Drawing.Size(132, 20);
            this.lblPrecioVentP.TabIndex = 59;
            this.lblPrecioVentP.Text = "Precio de venta ";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.White;
            this.txtPrecioVenta.Location = new System.Drawing.Point(348, 259);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(158, 20);
            this.txtPrecioVenta.TabIndex = 58;
            // 
            // lblPrecioCompP
            // 
            this.lblPrecioCompP.AutoSize = true;
            this.lblPrecioCompP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecioCompP.Location = new System.Drawing.Point(164, 228);
            this.lblPrecioCompP.Name = "lblPrecioCompP";
            this.lblPrecioCompP.Size = new System.Drawing.Size(146, 20);
            this.lblPrecioCompP.TabIndex = 57;
            this.lblPrecioCompP.Text = "Precio de compra ";
            // 
            // txtPrecioComp
            // 
            this.txtPrecioComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtPrecioComp.ForeColor = System.Drawing.Color.White;
            this.txtPrecioComp.Location = new System.Drawing.Point(348, 230);
            this.txtPrecioComp.Name = "txtPrecioComp";
            this.txtPrecioComp.Size = new System.Drawing.Size(158, 20);
            this.txtPrecioComp.TabIndex = 56;
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.nudCantidad.ForeColor = System.Drawing.Color.White;
            this.nudCantidad.Location = new System.Drawing.Point(348, 204);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(158, 20);
            this.nudCantidad.TabIndex = 55;
            // 
            // lblDescripccionP
            // 
            this.lblDescripccionP.AutoSize = true;
            this.lblDescripccionP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripccionP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescripccionP.Location = new System.Drawing.Point(164, 296);
            this.lblDescripccionP.Name = "lblDescripccionP";
            this.lblDescripccionP.Size = new System.Drawing.Size(169, 20);
            this.lblDescripccionP.TabIndex = 54;
            this.lblDescripccionP.Text = "Descripción producto";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(348, 298);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(158, 20);
            this.txtDescripcion.TabIndex = 53;
            // 
            // lblCantidadP
            // 
            this.lblCantidadP.AutoSize = true;
            this.lblCantidadP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidadP.Location = new System.Drawing.Point(164, 206);
            this.lblCantidadP.Name = "lblCantidadP";
            this.lblCantidadP.Size = new System.Drawing.Size(78, 20);
            this.lblCantidadP.TabIndex = 52;
            this.lblCantidadP.Text = "Cantidad";
            // 
            // lblMarcaP
            // 
            this.lblMarcaP.AutoSize = true;
            this.lblMarcaP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMarcaP.Location = new System.Drawing.Point(164, 177);
            this.lblMarcaP.Name = "lblMarcaP";
            this.lblMarcaP.Size = new System.Drawing.Size(63, 20);
            this.lblMarcaP.TabIndex = 51;
            this.lblMarcaP.Text = "Marca ";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtMarca.ForeColor = System.Drawing.Color.White;
            this.txtMarca.Location = new System.Drawing.Point(348, 177);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(158, 20);
            this.txtMarca.TabIndex = 50;
            // 
            // lblColorP
            // 
            this.lblColorP.AutoSize = true;
            this.lblColorP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblColorP.Location = new System.Drawing.Point(164, 151);
            this.lblColorP.Name = "lblColorP";
            this.lblColorP.Size = new System.Drawing.Size(49, 20);
            this.lblColorP.TabIndex = 49;
            this.lblColorP.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtColor.ForeColor = System.Drawing.Color.White;
            this.txtColor.Location = new System.Drawing.Point(348, 151);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(158, 20);
            this.txtColor.TabIndex = 48;
            // 
            // lblCodigoproducto
            // 
            this.lblCodigoproducto.AutoSize = true;
            this.lblCodigoproducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoproducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCodigoproducto.Location = new System.Drawing.Point(164, 125);
            this.lblCodigoproducto.Name = "lblCodigoproducto";
            this.lblCodigoproducto.Size = new System.Drawing.Size(164, 20);
            this.lblCodigoproducto.TabIndex = 47;
            this.lblCodigoproducto.Text = "Codigo del producto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(348, 125);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(158, 20);
            this.txtCodigo.TabIndex = 46;
            // 
            // lblNomProduct
            // 
            this.lblNomProduct.AutoSize = true;
            this.lblNomProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomProduct.Location = new System.Drawing.Point(164, 99);
            this.lblNomProduct.Name = "lblNomProduct";
            this.lblNomProduct.Size = new System.Drawing.Size(168, 20);
            this.lblNomProduct.TabIndex = 45;
            this.lblNomProduct.Text = "Nombre del producto";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(348, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(321, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "Productos ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FRMProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMProductos";
            this.Text = "FRMProductos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox ibtnInicio;
        private FontAwesome.Sharp.IconButton ibCancelar;
        private FontAwesome.Sharp.IconButton ibGuardar;
        private System.Windows.Forms.Label lblPrecioVentP;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblPrecioCompP;
        private System.Windows.Forms.TextBox txtPrecioComp;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblDescripccionP;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCantidadP;
        private System.Windows.Forms.Label lblMarcaP;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblColorP;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblCodigoproducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNomProduct;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}