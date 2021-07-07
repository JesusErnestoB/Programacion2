using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALL
{
    class D_Conexion
    {
        //Cadena de Conexion
        private readonly string cadena = "data source = LAPTOP-OEBH68R2; initial catalog = DBPapeleria_Memo; integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        public SqlConnection Conectar = new SqlConnection();

        //Constructor
        public D_Conexion()
        {
            Conectar.ConnectionString = cadena;
        }
            

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectar.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD "+ ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conectar.Close();
        }
    }   
}
