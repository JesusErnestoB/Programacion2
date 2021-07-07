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
        private B_OperacionEmpleadosAgregar b_Empleado = new B_OperacionEmpleadosAgregar();
        private B_OperacionDomicilio b_Domicilio = new B_OperacionDomicilio();

        string NombreE, ApellidoP, ApellidoM, Sexo, calle, colonia, localidad, municipio, estado, Direccion;
        int Edad, idDom;

       
        public FRMEmpleadosAgregar()
        {
            InitializeComponent();
        }

        private void lblidempleados_Click(object sender, EventArgs e)
        {

        }

        private void ibEditar_Click(object sender, EventArgs e)
        {
            BorraError();
            if (Validar())
            {
                ConversionesActualizar();
                LimpiarControles();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var lista = b_Empleado.Buscar_empleados_especifico(txtBuscar.Text);
            dgvEmpleados.DataSource = lista;
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreE.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtApPaterno.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApMaterno.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            txtEdad.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtSexo.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtCalleE.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            txtColoniaE.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
            txtLocalidadE.Text = dgvEmpleados.CurrentRow.Cells[7].Value.ToString();
            txtMuniciopioE.Text = dgvEmpleados.CurrentRow.Cells[8].Value.ToString();
            txtEstadoE.Text = dgvEmpleados.CurrentRow.Cells[9].Value.ToString();
            lblidDomicilio.Text = dgvEmpleados.CurrentRow.Cells[10].Value.ToString();
            lblidempleados.Text = dgvEmpleados.CurrentRow.Cells[11].Value.ToString();
        }

        private void ibMostrar_Click(object sender, EventArgs e)
        {
            var lista = b_Empleado.Buscar_Empleados();
            dgvEmpleados.DataSource = lista;
        }

        private void ibGuardar_Click(object sender, EventArgs e)
        {
            BorraError();
            if (Validar())
            {
                Conversiones();
                LimpiarControles();
            }
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

        private bool Validar()
        {
            bool ok = true;
            if (txtNombreE.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreE, "Ingrese  el nombre completo");
            }


            if (txtApPaterno.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApPaterno, "Ingrese el apellido paterno");

            }

            if (txtApMaterno.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApMaterno, "Ingrese el apellido materno");

            }

            if (txtEdad.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtEdad, "Ingrese la edad");

            }

            if (txtSexo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtSexo, "Ingrese el sexo");

            }

            if (txtCalleE.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCalleE, "Ingrese  la calle");

            }

            if (txtColoniaE.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtColoniaE, "Ingrese la colonia");

            }

            if (txtMuniciopioE.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtMuniciopioE, "Ingrese el municipio");
            }
            return ok;

        }

        public void Conversiones()
        {
            NombreE = txtNombreE.Text.ToUpper();
            ApellidoM = txtApMaterno.Text.ToUpper();
            ApellidoP = txtApPaterno.Text.ToUpper();
            Sexo = txtSexo.Text.ToUpper();
            Edad = Convert.ToInt32(txtEdad.Text);
            calle = txtCalleE.Text.ToUpper();
            colonia = txtColoniaE.Text.ToUpper();
            localidad = txtLocalidadE.Text.ToUpper();
            municipio = txtMuniciopioE.Text.ToUpper();
            estado = txtEstadoE.Text.ToUpper();

            string id_Domicilio = b_Domicilio.InsertarDomicilio(calle, colonia, localidad, municipio, estado);

            if (id_Domicilio == "error")
            {
                MessageBox.Show("Ocurrio un error"); return;
            }

            b_Empleado.InsertarEmpleados(NombreE, ApellidoP, ApellidoM, Sexo, Edad, id_Domicilio);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void BorraError()
        {
            errorProvider1.SetError(txtNombreE, "");
            errorProvider1.SetError(txtApPaterno, "");
            errorProvider1.SetError(txtApMaterno, "");
            errorProvider1.SetError(txtEdad, "");
            errorProvider1.SetError(txtSexo, "");
            errorProvider1.SetError(txtCalleE, "");
            errorProvider1.SetError(txtColoniaE, "");
            errorProvider1.SetError(txtLocalidadE, "");
            errorProvider1.SetError(txtMuniciopioE, "");
            errorProvider1.SetError(txtEstadoE, "");
        }

        public void ConversionesActualizar()
        {
            NombreE = txtNombreE.Text.ToUpper();
            ApellidoM = txtApMaterno.Text.ToUpper();
            ApellidoP = txtApPaterno.Text.ToUpper();
            Sexo = txtSexo.Text.ToUpper();
            Edad = int.Parse(txtEdad.Text);
            calle = txtCalleE.Text.ToUpper();
            colonia = txtColoniaE.Text.ToUpper();
            localidad = txtLocalidadE.Text.ToUpper();
            municipio = txtMuniciopioE.Text.ToUpper();
            estado = txtEstadoE.Text.ToUpper();

            b_Empleado.ActualizarEmpleados(lblidempleados.Text,NombreE, ApellidoP, ApellidoM, Sexo, Edad);
            b_Domicilio.ActualizarDomicilio(lblidDomicilio.Text,calle, colonia, localidad, municipio, estado);

            

            
        }

    }
}
