using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DALL.Modelos
{
    class D_Compra
    {
        D_Conexion conexion = new D_Conexion();

        public int id_Compra { get; set; }
        public DateTime fechaComp { get; set; }
        public float  total { get; set; }
        public int idEmpleado { get; set; }
        public int idProveedor { get; set; }



        public bool Insertar()
        {
            bool success = false;

            try
            {
                conexion.abrir();
                string sql = "INSERT INTO Compra VALUES ('" + fechaComp + "'," + total + "," + idEmpleado+","+idProveedor;

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
        public bool Actualizacion()
        {
            bool success = false;

            try
            {
                conexion.abrir();
                string sql = "UPDATE Compra SET  fecha= '" + fechaComp.ToString() + "',total =" + total + ", idEmpleado =" + idEmpleado + ", idProveedor= " + idProveedor;

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
