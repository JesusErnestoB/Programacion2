using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FRMProductos : Form
    {
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
            LimpiarControles();
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
    }
}
