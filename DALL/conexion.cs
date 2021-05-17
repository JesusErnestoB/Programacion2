using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DALL
{
    class conexion
    {

        public static SqlConnection Conectar()
        {

            SqlConnection Conex = new SqlConnection("data source=LAPTOP-OEBH68R2;initial catalog=DBPapeleria_Memo;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
            Conex.Open();

            return Conex;
        }
    }
}
