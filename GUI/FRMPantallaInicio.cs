using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class FRMPantallaInicio : Form
    {
        public FRMPantallaInicio()
        {
            InitializeComponent();
            InicializarMenu();
        }

        #region Mover Pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Barra_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Metodo de inacializacion
        private void InicializarMenu()
        {
            pnlProductos.Visible = false;
            pnlClientes.Visible = false;
            pnlCompras.Visible = false;
            pnlEmpleados.Visible = false;
            pnlReporte.Visible = false;
            pnlProveedor.Visible = false;

        }

        #endregion

        #region Metodos para ocultar y mostrar
        private void Ocultarsubmenu()
        {
            if (pnlProductos.Visible == true)
            {
                pnlProductos.Visible = false;
            }
            if (pnlClientes.Visible == true)
            {
                pnlClientes.Visible = false;
            }
            if (pnlCompras.Visible == true)
            {
                pnlCompras.Visible = false;
            }
            if (pnlEmpleados.Visible == true)
            {
                pnlEmpleados.Visible = false;
            }
            if (pnlReporte.Visible == true)
            {
                pnlReporte.Visible = false;
            }
            if (pnlProveedor.Visible == true)
            {
                pnlProveedor.Visible = false;
            }
        }

        private void ocultarMostrarSubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                Ocultarsubmenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        #endregion

        #region Click Botones

        #region Controles principales

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        #endregion

        #region Productos
        private void ibProductos_Click(object sender, EventArgs e)
        {
            ocultarMostrarSubmenu(pnlProductos);
        }

        private void ibAgreagarProducto_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FRMProductos());
            ocultarMostrarSubmenu(pnlProductos);
        }

        private void ibEditarProd_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FRMProductos());
            ocultarMostrarSubmenu(pnlProductos);
            
        }

        private void ibBuscarProd_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FRMProductos());
            ocultarMostrarSubmenu(pnlProductos);

        }
        #endregion

        private void ibVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FRMVentas());
        }

        #region Clientes
        private void ibClientes_Click(object sender, EventArgs e)
        {
            ocultarMostrarSubmenu(pnlClientes);
        }

        private void ibAgrarC_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FRMClientesAgregar());
            ocultarMostrarSubmenu(pnlClientes);
        }

        private void ibEditarC_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FRMClientesAgregar());
            ocultarMostrarSubmenu(pnlClientes);
        }

        private void ibBuscarC_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FRMClientesAgregar());
            ocultarMostrarSubmenu(pnlClientes);
        }
        #endregion

        #region Compras
        private void ibCompras_Click(object sender, EventArgs e)
        {
            ocultarMostrarSubmenu(pnlCompras);
        }
        private void ibRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FRMComprasRegistrar());
            ocultarMostrarSubmenu(pnlCompras);
        }
        #endregion

        #region Empleados 
        private void ibEmpleados_Click(object sender, EventArgs e)
        {
            ocultarMostrarSubmenu(pnlEmpleados);
        }

        private void ibAgregarEm_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FRMEmpleadosAgregar());
            ocultarMostrarSubmenu(pnlEmpleados);

        }

        private void ibBusacarEm_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FRMEmpleadosBuscaryEditar());
            ocultarMostrarSubmenu(pnlEmpleados);
        }

        private void ibEditarEm_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FRMEmpleadosBuscaryEditar());
            ocultarMostrarSubmenu(pnlEmpleados);
        }

        #endregion

        #region Proveedores

        private void ibProveedor_Click(object sender, EventArgs e)
        {
            ocultarMostrarSubmenu(pnlProveedor);
        }
        private void ibtnBuscarProv_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FRMProveedor());
            ocultarMostrarSubmenu(pnlProveedor);
        }

        private void ibtnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FRMProveedor());
            ocultarMostrarSubmenu(pnlProveedor);
        }
        #endregion

        #region Reportes
        private void ibReporte_Click(object sender, EventArgs e)
        {
            ocultarMostrarSubmenu(pnlReporte);
        }

        private void ibtnReporteVenta_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FRMReporteVentas());
            ocultarMostrarSubmenu(pnlReporte);
        }
        
        private void ibtnReporteCompra_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FRMReportecompra());
            ocultarMostrarSubmenu(pnlReporte);
        }
        
        private void ibtnReporteMasVendido_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FRMReprteMasVendido());
            ocultarMostrarSubmenu(pnlReporte);
        }


        #endregion


        #endregion

         #region Abrir Formulario Hijo
        public void AbrirFormHija(object formHija)
        {
            if (this.pnlInicio.Controls.Count > 0)
            {
                this.pnlInicio.Controls.RemoveAt(0);
            }
            Form FrmHija = formHija as Form;
            FrmHija.TopLevel = false;
            FrmHija.Dock = DockStyle.Fill;
            this.pnlInicio.Controls.Add(FrmHija);
            this.pnlInicio.Tag = FrmHija;
            FrmHija.Show();
        }



        #endregion

        private void Barra_Titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    } 
}
