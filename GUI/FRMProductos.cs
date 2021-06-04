using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace GUI
{
    public partial class FRMProductos : Form
    {
        private B_OperacionProductos objOperacionesProductos = new B_OperacionProductos();

        string Nombre, codigo, marca, color, descripcion;
        int cantidad;
        float precioComp, PrecioVen;
        public FRMProductos()
        {
            InitializeComponent();
        }

        private void ibtnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibGuardar_Click(object sender, EventArgs e)
        {
            convrsiones();
            Validacion();

            MessageBox.Show(objOperacionesProductos.InsertarProductos(Nombre, codigo, marca, cantidad, color, precioComp, PrecioVen, descripcion));

            LimpiarControles();

        }

        public void convrsiones()
        {
            Nombre = txtNombre.Text.ToUpper();
            codigo = txtCodigo.Text.ToUpper();
            marca = txtMarca.Text.ToUpper();
            cantidad = Convert.ToInt32(nudCantidad);
            color = txtColor.Text.ToUpper();
            precioComp = float.Parse(txtPrecioComp.Text);
            PrecioVen = float.Parse(txtPrecioVenta.Text);
            descripcion = txtDescripcion.Text.ToUpper();
        }

        public void LimpiarControles()
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            txtColor.Clear();
            txtMarca.Clear();
            nudCantidad.Value = 1;
            txtDescripcion.Clear();
            txtPrecioComp.Clear();
            txtPrecioVenta.Clear();

            txtNombre.Focus();


        }

        private void ibCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void Validacion()
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "ingresa el nombre del producto");
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtCodigo.Text == "")
            {
                errorProvider1.SetError(txtCodigo, "Ingresa el codigo");
            }
            errorProvider1.SetError(txtCodigo, "");

            if (txtColor.Text == "")
            {
                errorProvider1.SetError(txtColor, "Ingresa el color");
            }
            errorProvider1.SetError(txtColor, "");

            if (txtMarca.Text == "")
            {
                errorProvider1.SetError(txtMarca, "Ingresa la marca");
            }
            errorProvider1.SetError(txtMarca, "");


            if (txtPrecioComp.Text == "")
            {
                errorProvider1.SetError(txtPrecioComp, "Ingresa el precio de compra");
            }
            errorProvider1.SetError(txtPrecioComp, "");


            if (txtPrecioVenta.Text == "")
            {
                errorProvider1.SetError(txtPrecioVenta, "Ingresa el codigo");
            }
            errorProvider1.SetError(txtPrecioVenta, "");


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
