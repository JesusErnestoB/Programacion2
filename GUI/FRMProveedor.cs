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
    public partial class FRMProveedor : Form
    {
        public FRMProveedor()
        {
            InitializeComponent();
        }

        private void ibGuardar_Click(object sender, EventArgs e)
        {
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

    }
}
