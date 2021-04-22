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
    }
}
