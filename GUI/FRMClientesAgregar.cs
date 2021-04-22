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
    }
}
