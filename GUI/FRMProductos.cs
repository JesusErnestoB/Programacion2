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
        private B_OperacionProductos b_OperacionesProductos = new B_OperacionProductos();

        string Nombre, codigo, marca, color, descripcion;
        int cantidad, id;
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
            BorrarError(); 
            if (Validacion())
            {
                convrsiones();
                MessageBox.Show("se registro correctamente");
             LimpiarControles();
            }
        

        }

        public void convrsiones()
        {
            Nombre = txtNombre.Text.ToUpper();
            codigo = txtCodigo.Text.ToUpper();
            marca = txtMarca.Text.ToUpper();
            cantidad = Convert.ToInt32(nudCantidad.Value);
            color = txtColor.Text.ToUpper();
            precioComp = float.Parse(txtPrecioComp.Text);
            PrecioVen = float.Parse(txtPrecioVenta.Text);
            descripcion = txtDescripcion.Text.ToUpper();
            
            b_OperacionesProductos.InsertarProductos(Nombre, codigo, marca, cantidad, color, precioComp, PrecioVen, descripcion);
        }

        private void ibMostrar_Click(object sender, EventArgs e)
        {
            var lista = b_OperacionesProductos.Buscar_Productos();
            dgvProductos.DataSource = lista;
        }

        private void ibEditar_Click(object sender, EventArgs e)
        {
            BorrarError();
            if (Validacion())
            {
                ConversionActualizar();
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtNombre.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            txtCodigo.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtColor.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            txtMarca.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            nudCantidad.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            txtPrecioComp.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
            txtPrecioVenta.Text =  dgvProductos.CurrentRow.Cells[6].Value.ToString();
            txtDescripcion.Text = dgvProductos.CurrentRow.Cells[7].Value.ToString();
            idProducto.Text = dgvProductos.CurrentRow.Cells[8].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ibCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private bool Validacion()
        {
            bool ok= true;

            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "ingresa el nombre del producto");
            }
            return ok;

            if (txtCodigo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCodigo, "Ingresa el codigo");
            }
            return ok;

            if (txtColor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtColor, "Ingresa el color");
            }
            return ok;

            if (txtMarca.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtMarca, "Ingresa la marca");
            }
            return ok;


            if (txtPrecioComp.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPrecioComp, "Ingresa el precio de compra");
            }
            return ok;


            if (txtPrecioVenta.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPrecioVenta, "Ingresa el codigo");
            }
            return ok;


        }
       public void BorrarError()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtCodigo, "");
            errorProvider1.SetError(txtMarca, "");
            errorProvider1.SetError(nudCantidad, "");
            errorProvider1.SetError(txtPrecioComp, "");
            errorProvider1.SetError(txtColor, "");
            errorProvider1.SetError(txtPrecioVenta, "");
            errorProvider1.SetError(txtDescripcion, "");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void ConversionActualizar()
        {
            Nombre = txtNombre.Text.ToUpper();
            codigo = txtCodigo.Text.ToUpper();
            marca = txtMarca.Text.ToUpper();
            cantidad = Convert.ToInt32(nudCantidad.Value);
            color = txtColor.Text.ToUpper();
            precioComp = float.Parse(txtPrecioComp.Text);
            PrecioVen = float.Parse(txtPrecioVenta.Text);
            descripcion = txtDescripcion.Text.ToUpper();
            id = int.Parse(idProducto.Text);

            b_OperacionesProductos.ActualizarProductos(id, Nombre, codigo, marca, cantidad, color, precioComp, PrecioVen, descripcion);
        }
    }
}
