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
        B_OperacionesProveedores b_OperacionProveedores = new B_OperacionesProveedores();
        B_OperacionDomicilio b_OperacionDomicilio = new B_OperacionDomicilio();

        string nombre, correo, telefono, calle, colonia, localidad, municipio, estado;
        int domicilio, id;

        private void ibCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void ibMostrar_Click_1(object sender, EventArgs e)
        {
            var lista = b_OperacionProveedores.Buscar_Proveedores();
            dgvProveedores.DataSource = lista;
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreProv.Text = dgvProveedores.CurrentRow.Cells[0].ToString();
            txtEmail.Text = dgvProveedores.CurrentRow.Cells[1].ToString();
            txtTelefono.Text = dgvProveedores.CurrentRow.Cells[2].ToString();
            txtCalleProv.Text = dgvProveedores.CurrentRow.Cells[3].ToString();
            txtColoniaProv.Text = dgvProveedores.CurrentRow.Cells[4].ToString();
            txtLocalidadProv.Text = dgvProveedores.CurrentRow.Cells[5].ToString();
            txtMuniciopioProv.Text = dgvProveedores.CurrentRow.Cells[6].ToString();
            txtEstadoProv.Text = dgvProveedores.CurrentRow.Cells[7].ToString();
        }

       

       
        public FRMProveedor()
        {
            InitializeComponent();
        }

        private void ibGuardar_Click(object sender, EventArgs e)
        {
            Validar();
            Conversiones();
            MessageBox.Show( b_OperacionDomicilio.InsertarDomicilio(calle, colonia, localidad, municipio, estado));
            MessageBox.Show(b_OperacionProveedores.InsertarProveedores(nombre, correo, telefono, domicilio));

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
