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
        B_OperacionesClientes b_OperacionesClientes = new B_OperacionesClientes();
        B_OperacionDomicilio objDomiclio = new B_OperacionDomicilio();

        string nombreC, Telefono, Calle, colonia, localodad, municipio, estado, id_Domicilio;
        int idcliente;


        public FRMClientesAgregar()
        {
            InitializeComponent();
            id_Domicilio = "";
        }

        private void ibMostrar_Click(object sender, EventArgs e)
        {
            var lista = b_OperacionesClientes.Buscar_Clientes();
            dgvClientes.DataSource = lista;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreC.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            txtTelefonoC.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtCalleC.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtColoniaC.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtLocalidadC.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtMuniciopioC.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            txtEstadoC.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            lblidDomicilio.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
            lblIdClientes.Text = dgvClientes.CurrentRow.Cells[8].Value.ToString();
        }



        private void ibtnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibEditar_Click(object sender, EventArgs e)
        {
            BorrarError();
            if (Validar())
            {
                conversionActualizar();
                Vaciar();
            }
        }

        private void pnlClientes_Paint(object sender, PaintEventArgs e)
        {

        }
        public void buscsrclienteespecifico()
        {
            var lista=b_OperacionesClientes.Buscar_Clientes_especifico(txtbuscarEspecificos.Text);
            dgvClientes.DataSource = lista;
        }

        private void txtbuscarEspecificos_TextChanged(object sender, EventArgs e)
        {
            buscsrclienteespecifico();
        }

        private void ibGuardarClientes_Click(object sender, EventArgs e)
        {
            BorrarError();
            if (Validar())
            {
                conversionDomicilio();
             
                Vaciar();
            }

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

        private bool Validar()
        {
            bool ok = true;
            if (txtNombreC.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreC, "Ingrese el nombre");
            }


            string numero = @"\d{10}";
            Regex expresion = new Regex(numero);
            MatchCollection Match = expresion.Matches(txtTelefonoC.Text);
            if (Match.Count > 0)
            {

            }
            else
            {
                ok = false;
                errorProvider1.SetError(txtTelefonoC, "Digite 10 números");
            }
            

            if (txtCalleC.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCalleC, "Ingresae  la calle");

            }
            

            if (txtColoniaC.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtColoniaC, "Ingrese la colonia");

            }
           

            if (txtMuniciopioC.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtMuniciopioC, "Ingrese el municipio");

            }
            
            return ok;
        } 

      
        public void conversionDomicilio()
        {
            nombreC = txtCalleC.Text.ToUpper();
            Telefono = txtTelefonoC.Text.ToUpper();
            Calle = txtCalleC.Text.ToUpper();
            colonia = txtColoniaC.Text.ToUpper();
            localodad = txtLocalidadC.Text.ToUpper();
            municipio = txtMuniciopioC.Text.ToUpper();
            estado = txtEstadoC.Text.ToUpper();

            string id_Domicilio = objDomiclio.InsertarDomicilio(Calle, colonia, localodad, municipio, estado);

            if (id_Domicilio =="error")
            {
                MessageBox.Show("Ocurrio un error"); return;
            }

            b_OperacionesClientes.InsertarClientes(nombreC, Telefono, id_Domicilio);
        }
        public void BorrarError()
        {
            errorProvider1.SetError(txtNombreC, "");
            errorProvider1.SetError(txtTelefonoC, "");
            errorProvider1.SetError(txtCalleC, "");

            errorProvider1.SetError(txtColoniaC, "");
            errorProvider1.SetError(txtLocalidadC, "");
            errorProvider1.SetError(txtMuniciopioC, "");
            errorProvider1.SetError(txtEstadoC, "");
        }
        public void conversionActualizar()
        {
            idcliente= int.Parse(lblIdClientes.Text);
            nombreC = txtNombreC.Text.ToUpper();
            Telefono = txtTelefonoC.Text.ToUpper();
            Calle = txtCalleC.Text.ToUpper();
            colonia = txtColoniaC.Text.ToUpper();
            localodad = txtLocalidadC.Text.ToUpper();
            municipio = txtMuniciopioC.Text.ToUpper();
            estado = txtEstadoC.Text.ToUpper();
                 b_OperacionesClientes.ActualizarClientes(idcliente,nombreC, Telefono);
            objDomiclio.ActualizarDomicilio(lblidDomicilio.Text, Calle, colonia, localodad, municipio, estado);
                   

            
        }
    }
    
}
