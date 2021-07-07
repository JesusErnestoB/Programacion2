using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL;
using System.Data;
using System.Data.SqlClient;

namespace Business
{
    public class B_Venta_producto
    {
        public D_Venta_Productos dventa = new D_Venta_Productos();


        public DataTable buscar_productoespecific(string busqueda)
        {
            try
            {
                return dventa.BuscarProducto(busqueda);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable Agregar(string producto)
        {
            DataTable tabla;
            try
            {
                tabla =  dventa.AgregarProducto(producto);
            }
            catch (Exception e)
            {

                tabla = null;
            }

            return tabla;
        }


        public bool RegistrarVenta( string detalle ,double subtotal, double  total)
        {
            return dventa.RealizarVenta(detalle,subtotal,total);
        }
        

    }
}
