using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALL.Modelos
{
    public class D_Empleados
    {
        private D_Conexion conexion = new D_Conexion();

        public string idEmpleados { get; set; }
        public string NombreEm { get; set; }
        public string ApellidoPE { get; set; }
        public string ApellidoME { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }


        public bool Insertar()
        {
            bool success = false;
            try
            {
                conexion.abrir();
                string sql = "INSERT INTO Empleado VALUES ('" + NombreEm + "','" + ApellidoPE + "','";
                sql += ApellidoME + "','" + Sexo + "'," + Edad.ToString()+",'"+ Direccion.ToString() + "')";

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

        public bool Actualizar(string Id)
        {
            bool success = false;
            Id = idEmpleados;

            try
            {
                conexion.abrir();

                string sql = "UPDATE Empleado SET nombreE = '" + NombreEm.ToString() + "',apellidoP ='" + ApellidoPE.ToString() + "', apellidoM ='" + ApellidoME.ToString() + "'";
                sql += " ,sexo =' " + Sexo + "', edad = " + Edad +  " WHERE id = " + Id;

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

        public DataTable BuscarEmpleados()
        {
            DataTable TablaEmpleados = new DataTable();
            try
            {
                conexion.abrir();

                string sql = "select Empleado.nombreE,apellidoP,apellidoM, sexo, edad,Domicilio.calle,Colonia,Localidad,Municipio, Estado, Domicilio.id, Empleado.id";
                       sql += " from Empleado inner join Domicilio on Empleado.Direccion = Domicilio.id";
                
                var cmd = new SqlCommand(sql, conexion.Conectar);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }

                TablaEmpleados.Load(reader);

                conexion.cerrar();



            }
            catch (Exception)
            {

                throw;
            }
            return TablaEmpleados;
        }

        public DataTable BuscarEmpleadoEspecifico(string nombre)
        {
            DataTable TablaClientes = new DataTable();
            try
            {
                conexion.abrir();

                string Buscar = "select Empleado.nombreE,apellidoP,apellidoM, sexo, edad,Domicilio.calle,Colonia,Localidad,Municipio, Estado, Domicilio.id, Empleado.id";
                Buscar += " from Empleado inner join Domicilio on Empleado.Direccion = Domicilio.id where nombreE like " + "'%" + nombre + "%'";

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
