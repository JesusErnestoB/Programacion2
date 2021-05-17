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
    public partial class FRMComprasRegistrar : Form
    {
        public FRMComprasRegistrar()
        {
            InitializeComponent();
        }

        private void ibGuardar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        public void LimpiarControles()
        {
            txtNombre.Clear();
            txtProveedor.Clear();
            txtTotal.Clear();

            txtNombre.Focus();
        }

        private void Validar()
        {
            if (txtNombre .Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre");
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtProveedor.Text == "")
            {
                errorProvider1.SetError(txtProveedor, "Ingrese el nombre del proveedor");
                return;
            }
            errorProvider1.SetError(txtProveedor, "");

            if (txtTotal.Text == "")
            {
                errorProvider1.SetError(txtTotal, "Coloque la cantidad");
                return;
            }
            errorProvider1.SetError(txtTotal, "");
        }
        private void ibtnInicio_Click(object sender, EventArgs e)
        {

        }
    }
}
