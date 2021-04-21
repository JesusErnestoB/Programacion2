
namespace GUI
{
    partial class FRMVentas
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpVenta = new System.Windows.Forms.DateTimePicker();
            this.ibVender = new FontAwesome.Sharp.IconButton();
            this.ibCancelar = new FontAwesome.Sharp.IconButton();
            this.ibBuscarProd = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibtnInicio = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 480);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(943, 293);
            this.panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
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
            this.NomProducto,
            this.Codigo,
            this.Color,
            this.Marca,
            this.Cantidad,
            this.Descripcion,
            this.PrecioVenta});
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
            this.dataGridView1.Location = new System.Drawing.Point(93, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 284);
            this.dataGridView1.TabIndex = 31;
            // 
            // NomProducto
            // 
            this.NomProducto.Frozen = true;
            this.NomProducto.HeaderText = "Nombre del producto";
            this.NomProducto.Name = "NomProducto";
            // 
            // Codigo
            // 
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Codigo del producto";
            this.Codigo.Name = "Codigo";
            // 
            // Color
            // 
            this.Color.Frozen = true;
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            // 
            // Marca
            // 
            this.Marca.Frozen = true;
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Cantidad
            // 
            this.Cantidad.Frozen = true;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Descripcion
            // 
            this.Descripcion.Frozen = true;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.Frozen = true;
            this.PrecioVenta.HeaderText = "Precio de venta ";
            this.PrecioVenta.Name = "PrecioVenta";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpVenta);
            this.panel3.Controls.Add(this.ibVender);
            this.panel3.Controls.Add(this.ibCancelar);
            this.panel3.Controls.Add(this.ibBuscarProd);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(943, 100);
            this.panel3.TabIndex = 2;
            // 
            // dtpVenta
            // 
            this.dtpVenta.CalendarForeColor = System.Drawing.Color.White;
            this.dtpVenta.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dtpVenta.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpVenta.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dtpVenta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVenta.Location = new System.Drawing.Point(44, 3);
            this.dtpVenta.Name = "dtpVenta";
            this.dtpVenta.Size = new System.Drawing.Size(115, 26);
            this.dtpVenta.TabIndex = 27;
            this.dtpVenta.Value = new System.DateTime(2021, 4, 13, 16, 34, 46, 0);
            // 
            // ibVender
            // 
            this.ibVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibVender.ForeColor = System.Drawing.Color.White;
            this.ibVender.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.ibVender.IconColor = System.Drawing.Color.White;
            this.ibVender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibVender.IconSize = 30;
            this.ibVender.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibVender.Location = new System.Drawing.Point(571, 3);
            this.ibVender.Name = "ibVender";
            this.ibVender.Size = new System.Drawing.Size(78, 45);
            this.ibVender.TabIndex = 44;
            this.ibVender.Text = "Vender";
            this.ibVender.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibVender.UseVisualStyleBackColor = true;
            // 
            // ibCancelar
            // 
            this.ibCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibCancelar.ForeColor = System.Drawing.Color.White;
            this.ibCancelar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.ibCancelar.IconColor = System.Drawing.Color.White;
            this.ibCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibCancelar.IconSize = 30;
            this.ibCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibCancelar.Location = new System.Drawing.Point(675, 3);
            this.ibCancelar.Name = "ibCancelar";
            this.ibCancelar.Size = new System.Drawing.Size(78, 45);
            this.ibCancelar.TabIndex = 43;
            this.ibCancelar.Text = "Cancelar";
            this.ibCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibCancelar.UseVisualStyleBackColor = true;
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
            this.ibBuscarProd.Location = new System.Drawing.Point(404, 38);
            this.ibBuscarProd.Name = "ibBuscarProd";
            this.ibBuscarProd.Size = new System.Drawing.Size(30, 30);
            this.ibBuscarProd.TabIndex = 32;
            this.ibBuscarProd.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(234, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 42);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre \r\ndel producto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ibtnInicio);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 75);
            this.panel2.TabIndex = 1;
            // 
            // ibtnInicio
            // 
            this.ibtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ibtnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtnInicio.IconColor = System.Drawing.Color.White;
            this.ibtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnInicio.Location = new System.Drawing.Point(54, 20);
            this.ibtnInicio.Name = "ibtnInicio";
            this.ibtnInicio.Size = new System.Drawing.Size(32, 32);
            this.ibtnInicio.TabIndex = 67;
            this.ibtnInicio.TabStop = false;
            this.ibtnInicio.Click += new System.EventHandler(this.ibtnInicio_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(456, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ventas ";
            // 
            // FRMVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(943, 480);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMVentas";
            this.Text = "FRMVentas";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpVenta;
        private FontAwesome.Sharp.IconButton ibVender;
        private FontAwesome.Sharp.IconButton ibCancelar;
        private FontAwesome.Sharp.IconButton ibBuscarProd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox ibtnInicio;
        private System.Windows.Forms.Label label1;
    }
}