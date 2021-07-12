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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombreP_TextChanged(object sender, EventArgs e)
        {

        }

        private void ibEditar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                ConversionActualizar();
                LimpiarControles();
            }
        }

        private void ibMostrar_Click_1(object sender, EventArgs e)
        {
            var lista = b_OperacionProveedores.Buscar_Proveedores();
            dgvProveedores.DataSource = lista;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreProv.Text = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
            txtEmail.Text = dgvProveedores.CurrentRow.Cells[1].Value.ToString();
            txtTelefono.Text = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
            txtCalleProv.Text = dgvProveedores.CurrentRow.Cells[3].Value.ToString();
            txtColoniaProv.Text = dgvProveedores.CurrentRow.Cells[4].Value.ToString();
            txtLocalidadProv.Text = dgvProveedores.CurrentRow.Cells[5].Value.ToString();
            txtMuniciopioProv.Text = dgvProveedores.CurrentRow.Cells[6].Value.ToString();
            txtEstadoProv.Text = dgvProveedores.CurrentRow.Cells[7].Value.ToString();
            id_dOMICILIO.Text = dgvProveedores.CurrentRow.Cells[8].Value.ToString();
            lblid_Proveedor.Text = dgvProveedores.CurrentRow.Cells[9].Value.ToString();
        }




        public FRMProveedor()
        {
            InitializeComponent();
        }

        private void ibGuardar_Click(object sender, EventArgs e)
        {
            BorrarError();
            if (Validar())
            {
                Conversiones();
                LimpiarControles();
            }
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

        private bool Validar()
        {
            bool ok = true;
            if (txtNombreProv.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreProv, "Ingresa el nombre");
            }

            if (txtEmail.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtEmail, "Ingresa el correo electronico");
            }
            

            string numero = @"\d{10}";
            Regex expresion = new Regex(numero);
            MatchCollection elMatch = expresion.Matches(txtTelefono.Text);
            if (elMatch.Count > 0)
            {
            }
            else
            {
                ok = false;
                errorProvider1.SetError(txtTelefono, "requiere de 10 caracteres numericos");
            }

            if (txtCalleProv.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCalleProv, "Ingrese  la calle");
                
            }
         
            if (txtColoniaProv.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtColoniaProv, "Ingrese la colonia");
                
            }
            

            if (txtMuniciopioProv.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtMuniciopioProv, "Ingrese el municipio");
                
            }
            return ok;
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

            string id_Domicilio = b_OperacionDomicilio.InsertarDomicilio(calle, colonia, localidad, municipio, estado);

            if (id_Domicilio == "error")
            {
                MessageBox.Show("Ocurrio un error"); return;
            }

            b_OperacionProveedores.InsertarProveedores(nombre, correo, telefono, id_Domicilio);



        }
        public void BorrarError()
        {
            errorProvider1.SetError(txtNombreP, "");
            errorProvider1.SetError(txtEmail, "");
            errorProvider1.SetError(txtTelefono, "");
            errorProvider1.SetError(txtCalleProv, "");
            errorProvider1.SetError(txtColoniaProv, "");
            errorProvider1.SetError(txtLocalidadProv, "");
            errorProvider1.SetError(txtMuniciopioProv, "");
            errorProvider1.SetError(txtEstadoProv, "");


        }
         public void ConversionActualizar()
        {
            nombre = txtNombreProv.Text.ToUpper();
            correo = txtEmail.Text.ToUpper();
            telefono = txtTelefono.Text.ToUpper();
            calle = txtCalleProv.Text.ToUpper();
            colonia = txtColoniaProv.Text.ToUpper();
            localidad = txtLocalidadProv.Text.ToUpper();
            municipio = txtMuniciopioProv.Text.ToUpper();
            estado = txtEstadoProv.Text.ToUpper();

             b_OperacionDomicilio.ActualizarDomicilio(id_dOMICILIO.Text,calle, colonia, localidad, municipio, estado);

            b_OperacionProveedores.ActualizarProveedores(lblid_Proveedor.Text, nombre, correo, telefono);

        }

    }
}
