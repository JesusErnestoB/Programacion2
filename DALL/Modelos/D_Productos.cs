using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALL.Modelos
{
    public class D_Productos
    {
        private D_Conexion conexion = new D_Conexion();

        public int idProducto { get; set; }
        public string NombreP { get; set; }
        public string Codigo { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }
        public string Color { get; set; }
        public float PrecioComp { get; set; }
        public float PrecioVent { get; set; }
        public string Descripcion { get; set; }

        public bool Insertar()
        {
            bool success = false;
            try
            {
                conexion.abrir();
                string sql = "INSERT INTO Producto VALUES ('" + NombreP + "','";
                sql += Codigo + "','" + Marca + "'," + Cantidad.ToString() + ",'" + Color + "',";
                sql += PrecioComp.ToString() + "," + PrecioVent.ToString() + ",'" + Descripcion + "'";

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

        public bool Actualizar(int ID)
        {
            bool success = false;
            idProducto = ID;

            try
            {
                conexion.abrir();

                string sql = "UPDATE Producto SET nombre = '" + NombreP.ToString() + "',Codigo ='" + Codigo.ToString() + "', = Marca'" + Marca.ToString();
                sql += "',cantidad=" + Cantidad + ", Color ='" + Color.ToString() + "', PrecioCom = " + PrecioComp + ", PrecioVen= " + PrecioVent;
                sql += ", Descripcion= '" + Descripcion.ToString() + "' WHERE id_producto = " + ID;

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

        public DataTable BuscarProductos()
        {
            DataTable TablaProductos = new DataTable();
            try
            {
                conexion.abrir();

                string sql = "SELECT Codigo,nombre, Marca,cantidad,PrecioVen,Descripcion From Producto ";

                var cmd = new SqlCommand(sql, conexion.Conectar);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows==false)
                {
                    return null;
                }

                TablaProductos.Load(reader);

                conexion.cerrar();



            }
            catch (Exception)
            {

                throw;
            }
            return TablaProductos;

        }
    }
}
