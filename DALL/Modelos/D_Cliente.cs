using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALL.Modelos
{
    public class D_Cliente
    {
        private D_Conexion conexion = new D_Conexion();

        public int IdCliente { get; set; }
        public string NombreC { get; set; }
        public string telefono { get; set; }
        public int Direccion { get; set; }

        public bool Insertar()
        {
            bool success = false;
            try
            {
                conexion.abrir();
                string sql = "INSERT INTO   Cliente VALUES ('" + NombreC + "','" + telefono + "'," + Direccion+ ")";

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

        public void Mostrar()
        {

        }

        public void Borrar()
        {

        }

        public void Actualizar()
        {

        }
    }
}
