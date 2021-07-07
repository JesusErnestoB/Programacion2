using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace GUI
{
    public partial class FRMVentas : Form
    {
        B_Venta_producto bventas = new B_Venta_producto();
        B_OperacionProductos bProductos = new B_OperacionProductos();
        B_OperacionVenta b_Venta = new B_OperacionVenta();

        private double subtotal, total;
       
               

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
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show("Desea confirmar venta?", "Confirma", buttons);
            if (result != System.Windows.Forms.DialogResult.Yes)
                return;


            if (!(dataGridView1.Rows.Count > 1)) { MessageBox.Show("No hay productos agregados"); return; }
            DataTable dt = new DataTable();
            dt.Columns.Add("idproducto");
            dt.Columns.Add("cantidad");
            //Nuevo codigo
            string productos = "";
            string cantidades = "";

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                DataRow row = dt.NewRow();
                if (fila.Cells[0].Value == null) break;

                productos += fila.Cells[0].Value.ToString() + ",";
                cantidades += fila.Cells[3].Value.ToString() + ",";
                dt.Rows.Add(row);
            }
            string detalle = productos + ";" + cantidades;



            if (!bventas.RegistrarVenta(detalle, subtotal, total))
            {
                MessageBox.Show("No se pudo registrar la venta");
            }
            else { MessageBox.Show("Venta registrada correctamente!"); }

            dataGridView1.Rows.Clear();
            
            txtTotal.Text = "0";
            lblSubtotal.Text = "0";
            total = 0;
            subtotal = 0;
            
        }

        private void ibBuscarProd_Click(object sender, EventArgs e)
        {
            int cantidad;
            cantidad =Convert.ToInt32( Microsoft.VisualBasic.Interaction.InputBox("cantidad a vender ","Cantidad a vender", "1" ,100, 10));
            lblCantidad.Text = cantidad.ToString();
        }

        private void ibCancelar_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtPago.Clear();
            txtTotal.Clear();
            lblCambio.Text = " $ ";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar(txtBuscar.Text);
        }

        public void buscar(string buscar)
        {
            var lista = bventas.buscar_productoespecific(buscar);
            cmbAgregar.DataSource = lista;
            cmbAgregar.DisplayMember = "nombre";
            cmbAgregar.ValueMember = "id_producto";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            mostrarProductos();
        }
        public void mostrarProductos()
        {
            if (cmbAgregar.Text == "") return;
            string idproducto = cmbAgregar.SelectedValue.ToString();
            DataTable producto = bventas.Agregar(idproducto);
            if (producto == null) { MessageBox.Show("No se pudo agregar"); return; }
            int cantidad = Convert.ToInt32(numericUpDown1.Value);
            var pventa = Convert.ToDouble(producto.Rows[0]["PrecioVen"].ToString());
            var totalIva = pventa * .16 * cantidad;
            var total = pventa * cantidad + totalIva;
            dataGridView1.Rows.Insert(0, producto.Rows[0]["id_producto"], producto.Rows[0]["nombre"].ToString(), producto.Rows[0]["Codigo"], numericUpDown1.Value, producto.Rows[0]["PrecioVen"].ToString(), total);
            var idprod = Convert.ToInt32(producto.Rows[0]["id_producto"].ToString());
            this.total += total;
            this.subtotal += pventa * cantidad;

            lblSubtotal.Text = "Subtotal: " + this.subtotal.ToString();
            //lblTotal.Text = this.total.ToString();
            txtTotal.Text = this.total.ToString();
            lblidproducto.Text = idprod.ToString();
            lblCantidad.Text = cantidad.ToString();
        }
        public void venta()
        {
            
            string fecha = Convert.ToString(dtpVenta.Value.ToShortDateString()); 
            string id_venta= b_Venta.InsertarVenta(fecha , Convert.ToDouble(txtTotal.Text));
            if (id_venta == "error")
            {
                MessageBox.Show("Ocurrio un error"); return;
            }

            lblidVenta.Text = id_venta;
        }

        private void icbQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                subtotal -= Convert.ToDouble(dataGridView1.CurrentRow.Cells[3].Value) * Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value);
                total -= Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                lblSubtotal.Text = this.subtotal.ToString();
                txtTotal.Text = this.total.ToString();
            }
            catch (Exception ex) { MessageBox.Show("No se pudo" + ex.Message.ToString()); }
        }

      /*  public void realizar_Venta()
        {
            int idVenta = int.Parse(lblidVenta.Text);
            string id_Produc = (lblidproducto.Text);
            int cantidadp = int.Parse(lblCantidad.Text);

            bventas.InsertarProductos(idVenta, id_Produc, cantidadp);
        }*/

    }
}
