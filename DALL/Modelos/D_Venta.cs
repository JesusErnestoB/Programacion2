using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALL.Modelos
{
    public class D_Venta
    {
        D_Conexion conexion = new D_Conexion();

        public int idVenta { get; set; }
        public string Fecha  { get; set; }
        public double total { get; set; }
      


        public bool Insertar()
        {

            bool success = false;
            try
            {
                conexion.abrir();
                string sql = "INSERT INTO Venta VALUES( '"+ Fecha.ToString()+"',"+ total+" )";

                var cmd = new SqlCommand(sql, conexion.Conectar);
                var resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                    success = true;

                conexion.cerrar();
            }
            catch (Exception)
            {

                throw;
            }
            return success;
        }
    }
}
