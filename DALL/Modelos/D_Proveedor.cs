using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALL.Modelos
{
    public class D_Proveedor
    {
        private D_Conexion conexion = new D_Conexion();

        public int id_Proveedor { get; set; }
        public string Nombre { get; set; }
        public string CorreoE { get; set; }
        public string Telefono { get; set; }
        public int fk_Direccion { get; set; }

        public bool Insertar()
        {

            bool success = false;
            try
            {
                conexion.abrir();
                string sql = "INSERT INTO Proveedor VALUES ('" + Nombre + "','"+ CorreoE + "','" + Telefono + "'," + fk_Direccion.ToString() + ")";

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
        public bool Actualizar(int id)
        {
            bool Success = false;
            id = id_Proveedor;

            try
            {
                conexion.abrir();

                string sql = "UPDATE Proveedor SET nombre = '" + Nombre.ToString() + "',CorreoE ='" + CorreoE.ToString() + "', telefono ='" + Telefono.ToString()+"'";
                sql += "WHERE id_Proveedor = " + id;

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

        public DataTable BuscarProveedor()
        {
            DataTable TablaProveedores = new DataTable();
            try
            {
                conexion.abrir();

                string sql = "SELECT Proveedor.nombre,correoE,telefono,Domicilio.calle,Colonia,Localidad,Municipio,Estado" ;
                       sql += " from Proveedor inner join Domicilio on Proveedor.id_Direccion =Domicilio.id ";
                       
                var cmd = new SqlCommand(sql, conexion.Conectar);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }

                TablaProveedores.Load(reader);

                conexion.cerrar();



            }
            catch (Exception)
            {

                throw;
            }
            return TablaProveedores;

        }
    }
    
}
