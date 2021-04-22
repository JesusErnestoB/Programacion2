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
    public partial class FRMVentas : Form
    {
        public FRMVentas()
        {
            InitializeComponent();
        }

        private void ibtnInicio_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ibVender_Click(object sender, EventArgs e)
        {
            FRMVender Ventas = new FRMVender();
            Ventas.Show();
        }

        private void ibBuscarProd_Click(object sender, EventArgs e)
        {
            int cantidad;
            cantidad =Convert.ToInt32( Microsoft.VisualBasic.Interaction.InputBox("cantidad a vender ","Cantidad a vender", "1" ,100, 10));
        }
    }
}
