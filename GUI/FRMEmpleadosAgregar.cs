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
    public partial class FRMEmpleadosAgregar : Form
    {
        private B_OperacionEmpleadosAgregar objEmpleado = new B_OperacionEmpleadosAgregar();
        private B_OperacionDomicilio objDomicilio = new B_OperacionDomicilio();

        string NombreE, ApellidoP, ApellidoM, Sexo, calle, colonia, localidad, municipio, estado;

        int Edad ,Direccion;



        public FRMEmpleadosAgregar()
        {
            InitializeComponent();
        }

        private void ibGuardar_Click(object sender, EventArgs e)
        {
            Validar();
            Conversiones();
            objDomicilio.InsertarDomicilio(calle, colonia, localidad, municipio, estado);
            MessageBox.Show(objEmpleado.InsertarEmpleados(NombreE,ApellidoP,ApellidoM,Sexo,Edad,Direccion));
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

        public void Conversiones()
        {
            NombreE = txtNombreE.Text.ToUpper();
            ApellidoM = txtApMaterno.Text.ToUpper();
            ApellidoP = txtApPaterno.Text.ToUpper();
            Sexo = txtSexo.Text.ToUpper();
            Edad = Convert.ToInt32(txtEdad);
            calle = txtCalleE.Text.ToUpper();
            colonia = txtColoniaE.Text.ToUpper();
            localidad = txtLocalidadE.Text.ToUpper();
            municipio = txtMuniciopioE.Text.ToUpper();
            estado = txtEstadoE.Text.ToUpper();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
