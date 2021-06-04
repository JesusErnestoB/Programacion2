using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALL.Modelos
{
    public class D_Domicilio
    {
        private D_Conexion conexion = new D_Conexion();


        public int idDomicilio { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string Localidad { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }

        public bool Insertar()
        {
            bool success = false;
            try
            {
                conexion.abrir();
                string sql = "INSERT INTO Domicilio VALUES ('" + Calle + "','" + Colonia + "','" + Localidad + "','" + Municipio + "','" + Estado + "',";

                var cmd = new SqlCommand(sql, conexion.Conectar);
                var resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                {
                    success = true;
                }

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
