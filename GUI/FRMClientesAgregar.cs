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

namespace GUI
{
    public partial class FRMClientesAgregar : Form
    {
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
    }
}
