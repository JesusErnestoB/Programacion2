using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DALL.Modelos;

namespace Business
{
    public class B_OperacionVenta
    {
        public D_Venta dventa = new D_Venta();

        public string InsertarVenta(string fecha, double total)
        {
            try
            {
                dventa.Fecha = fecha;
                dventa.total = total;
               

                if (dventa.Insertar())
                {
                    return "Se inserto correctamente";
                }
                else
                {
                    return "No se inserto la venta";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
