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
        public string Direccion { get; set; }

        public bool Insertar()
        {
            bool success = false;
            try
            {
                conexion.abrir();
                string sql = "INSERT INTO   Cliente VALUES ('" + NombreC + "','" + telefono + "', '" + Direccion + " ')";

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

        public bool Actualizar()
        {
            bool Success = false;
        

            try
            {
                conexion.abrir();

                string sql = "UPDATE Cliente SET nombreC = '" + NombreC.ToString() + "', telefono ='" + telefono.ToString() + "'";
                sql += " WHERE id_Cliente = '" + IdCliente.ToString() +"'";

                var cmd = new SqlCommand(sql, conexion.Conectar);
                var resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                    Success = true;

                conexion.cerrar();
            }
            catch (Exception)
            {

                throw;
            }
            return Success;
        }
        public DataTable BuscarCliente()
        {
            DataTable TablaClientes = new DataTable();
            try
            {
                conexion.abrir();

                string Buscar = "select Cliente.nombreC,telefono,Domicilio.calle,colonia,Localidad,Municipio,Estado,id, Cliente.id_Cliente";
                       Buscar += " from Cliente inner join Domicilio on Cliente.Direccion = Domicilio.id";

                var cmd = new SqlCommand(Buscar, conexion.Conectar);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }

                TablaClientes.Load(reader);

                conexion.cerrar();

            }
            catch (Exception)
            {

                throw;
            }
            return TablaClientes;

        }
        public DataTable BuscarClienteespecifico(string nombre)
        {
            DataTable TablaClientes = new DataTable();
            try
            {
                conexion.abrir();

                string Buscar = "select Cliente.nombreC,telefono,Domicilio.calle,colonia,Localidad,Municipio,Estado,id, Cliente.id_Cliente";
                Buscar += " from Cliente inner join Domicilio on Cliente.Direccion = Domicilio.id where nombreC like " +"'%"+nombre+"%'";

                var cmd = new SqlCommand(Buscar, conexion.Conectar);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }

                TablaClientes.Load(reader);

                conexion.cerrar();

            }
            catch (Exception)
            {

                throw;
            }
            return TablaClientes;

        }
    }
}
