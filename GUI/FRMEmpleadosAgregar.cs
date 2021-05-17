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
    public partial class FRMEmpleadosAgregar : Form
    {
        public FRMEmpleadosAgregar()
        {
            InitializeComponent();
        }

        private void ibGuardar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        public void LimpiarControles()
        {
            txtNombreE.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
            txtEdad.Clear();
            txtSexo.Clear();
            txtCalleE.Clear();
            txtColoniaE.Clear();
            txtLocalidadE.Clear();
            txtMuniciopioE.Clear();
            txtEstadoE.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();

            txtNombreE.Focus();
        }

        private void ibCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();

        }

        private void Validar()
        {
            if (txtNombreE.Text == "")
            {
                errorProvider1.SetError(txtNombreE, "Ingrese  el nombre completo");
                return;
            }
            errorProvider1.SetError(txtNombreE, "");

            if (txtApPaterno.Text == "")
            {
                errorProvider1.SetError(txtApPaterno, "Ingrese el apellido paterno");
                return;
            }
            errorProvider1.SetError(txtApPaterno, "");

            if(txtApMaterno.Text == "")
            {
                errorProvider1.SetError(txtApMaterno, "Ingrese el apellido materno");
                return;
            }
            errorProvider1.SetError(txtApMaterno, "");

            if (txtEdad.Text == "")
            {
                errorProvider1.SetError(txtEdad, "Ingrese la edad");
                return;
            }
            errorProvider1.SetError(txtEdad, "");

            if (txtSexo.Text == "")
            {
                errorProvider1.SetError(txtSexo, "Ingrese el sexo");
                return;
            }
            errorProvider1.SetError(txtSexo, "");

            if (txtCalleE.Text == "")
            {
                errorProvider1.SetError(txtCalleE, "Ingrese  la calle");
                return;
            }
            errorProvider1.SetError(txtCalleE, "");

            if (txtColoniaE.Text == "")
            {
                errorProvider1.SetError(txtColoniaE, "Ingrese la colonia");
                return;
            }
            errorProvider1.SetError(txtColoniaE, "");

            if (txtMuniciopioE.Text == "")
            {
                errorProvider1.SetError(txtMuniciopioE, "Ingrese el municipio");
                return;
            }
            errorProvider1.SetError(txtMuniciopioE, "");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
