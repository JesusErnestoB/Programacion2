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


        public string  idDomicilio { get; set; }
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
                string sql = "INSERT INTO Domicilio VALUES ('" + Calle + "','" + Colonia + "','" + Localidad + "','" + Municipio + "','" + Estado + "')";

                var cmd = new SqlCommand(sql, conexion.Conectar);
                var resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                   success = true;
                

                    sql = "SELECT MAX(id) as ultimo_id_domic from Domicilio ";
                    cmd = new SqlCommand(sql, conexion.Conectar);
                    var reader = cmd.ExecuteReader();
                    reader.Read();
                    idDomicilio = reader.GetValue(0).ToString();
                

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
            bool success = false;

            try
            {
                conexion.abrir();

                string actualizar = "UPDATE Domicilio SET calle= '" + Calle + "',Colonia ='" + Colonia + " ',";
                actualizar += "Localidad='" + Localidad + "',Municipio='" + Municipio + "', Estado='" + Estado + "' where id= '" + idDomicilio + "'";

                var cmd = new SqlCommand(actualizar, conexion.Conectar);
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
        public DataTable BuscarDomicilio()
        {
            DataTable Tabladomicilio = new DataTable();
            try
            {
                conexion.abrir();

                string sql = "SELECT calle, Colonia, Localidad,Municipio,Estado,id  from Domicilio ";

                var cmd = new SqlCommand(sql, conexion.Conectar);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }

                Tabladomicilio.Load(reader);

                conexion.cerrar();



            }
            catch (Exception)
            {

                throw;
            }
            return Tabladomicilio;

        }
    }
}
