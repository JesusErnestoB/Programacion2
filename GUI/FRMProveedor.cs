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
    public partial class FRMProveedor : Form
    {
        B_OperacionesProveedores objOperacionProveedores = new B_OperacionesProveedores();
        B_OperacionDomicilio objOperacionDomicilio = new B_OperacionDomicilio();

        string nombre, correo, telefono, calle, colonia, localidad, municipio, estado;
        int domicilio,id;
        public FRMProveedor()
        {
            InitializeComponent();
        }

        private void ibGuardar_Click(object sender, EventArgs e)
        {
            Validar();
            Conversiones();
            objOperacionDomicilio.InsertarDomicilio(id,calle, colonia, localidad, municipio, estado);
            MessageBox.Show(objOperacionProveedores.InsertarProveedores(nombre, correo, telefono, domicilio));

            LimpiarControles();
        }

        public void LimpiarControles()
        {
            txtNombreProv.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtCalleProv.Clear();
            txtColoniaProv.Clear();
            txtLocalidadProv.Clear();
            txtMuniciopioProv.Clear();
            txtEstadoProv.Clear();

            txtNombreProv.Focus();
        }

        private void Validar()
        {
            if (txtNombreProv.Text == "")
            {
                errorProvider1.SetError(txtNombreProv, "Ingresa el nombre");
            }
            errorProvider1.SetError(txtNombreProv, "");

            if (txtEmail.Text == "")
            {
                errorProvider1.SetError(txtEmail, "Ingresa el correo electronico");
            }
            errorProvider1.SetError(txtEmail, "");

            string numero = @"\d{10}";
            Regex expresion = new Regex(numero);
            MatchCollection elMatch = expresion.Matches(txtTelefono.Text);
            if (elMatch.Count > 0)
            {
            }
            else
            {
                errorProvider1.SetError(txtTelefono, "requiere de 10 caracteres numericos");
            }

            if (txtCalleProv.Text == "")
            {
                errorProvider1.SetError(txtCalleProv, "Ingrese  la calle");
                return;
            }
            errorProvider1.SetError(txtCalleProv, "");

            if (txtColoniaProv.Text == "")
            {
                errorProvider1.SetError(txtColoniaProv, "Ingrese la colonia");
                return;
            }
            errorProvider1.SetError(txtColoniaProv, "");

            if (txtMuniciopioProv.Text == "")
            {
                errorProvider1.SetError(txtMuniciopioProv, "Ingrese el municipio");
                return;
            }
            errorProvider1.SetError(txtMuniciopioProv, "");
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Conversiones()
        {
            nombre = txtNombreProv.Text.ToUpper();
            correo = txtEmail.Text.ToUpper();
            telefono = txtTelefono.Text.ToUpper();
            calle = txtCalleProv.Text.ToUpper();
            colonia = txtColoniaProv.Text.ToUpper();
            localidad = txtLocalidadProv.Text.ToUpper();
            municipio = txtMuniciopioProv.Text.ToUpper();
            estado = txtEstadoProv.Text.ToUpper();

        }
    }
}
