using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Business;

namespace GUI
{
    public partial class FRMClientesAgregar : Form
    {
        B_OperacionesClientes objOPeracionesClientes = new B_OperacionesClientes();
        B_OperacionDomicilio objDomiclio = new B_OperacionDomicilio();

        string nombreC, Telefono, Calle, colonia, localodad, municipio, estado;
        int direccion;

        public FRMClientesAgregar()
        {
            InitializeComponent();
        }

        private void ibtnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibGuardarClientes_Click(object sender, EventArgs e)
        {
            Validar();
            Conversiones();

            objDomiclio.InsertarDomicilio(Calle, colonia, localodad, municipio, estado);
            MessageBox.Show(objOPeracionesClientes.InsertarClientes(nombreC, Telefono, direccion));

            Vaciar();
        }

        public void Vaciar()
        {
            txtNombreC.Clear();
            txtTelefonoC.Clear();
            txtCalleC.Clear();
            txtColoniaC.Clear();
            txtLocalidadC.Clear();
            txtMuniciopioC.Clear();
            txtEstadoC.Clear();
            txtNombreC.Focus();
        }

        private void ibCancelarClientes_Click(object sender, EventArgs e)
        {
            Vaciar();
        }
     
        private void Validar()
        {
            if (txtNombreC.Text == "")
            {
                errorProvider1.SetError(txtNombreC, "Ingrese el nombre");
                return;
            }
            errorProvider1.SetError(txtNombreC, "");

            string numero = @"\d{10}";
            Regex expresion = new Regex(numero);
            MatchCollection Match = expresion.Matches(txtTelefonoC.Text);
            if (Match.Count > 0)
            {
            }
            else
            {
                errorProvider1.SetError(txtTelefonoC, "Digite 10 números");
                return;
            }

            if (txtCalleC.Text == "")
            {
                errorProvider1.SetError(txtCalleC, "Ingresae  la calle");
                return;
            }
            errorProvider1.SetError(txtCalleC, "");

            if (txtColoniaC.Text == "")
            {
                errorProvider1.SetError(txtColoniaC, "Ingrese la colonia");
                return;
            }
            errorProvider1.SetError(txtColoniaC, "");

            if (txtMuniciopioC.Text == "")
            {
                errorProvider1.SetError(txtMuniciopioC, "Ingrese el municipio");
                return;
            }
            errorProvider1.SetError(txtMuniciopioC, "");        
        }

        public void Conversiones()
        {
            nombreC = txtCalleC.Text.ToUpper();
            Telefono = txtTelefonoC.Text.ToUpper();
            Calle = txtCalleC.Text.ToUpper();
            colonia = txtColoniaC.Text.ToUpper();
            localodad = txtLocalidadC.Text.ToUpper();
            municipio = txtMuniciopioC.Text.ToUpper();
            estado = txtEstadoC.Text.ToUpper();
        }
    }
}
