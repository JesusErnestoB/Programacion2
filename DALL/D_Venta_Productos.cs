using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DALL
{
    public class D_Venta_Productos
    {
        private D_Conexion conectar = new D_Conexion();
        
        public int idVenta { get; set; }
        public string idProducto { get; set; }
        public int Cantidad { get; set; }
        
        public DataTable BuscarProducto(string busqueda)
        {
            DataTable tablaProductos = new DataTable();
            try
            {
                conectar.abrir();
                string consulta = "select id_producto, nombre from Producto where nombre  LIKE " + "'%" + busqueda + "%' or id_producto LIKE " + "'%" + busqueda + "%'";
                SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablaProductos.Load(reader);
                conectar.cerrar();
            }
            catch (Exception)
            {

                throw;
            }
            return tablaProductos;
        }
        public DataTable AgregarProducto(string producto)
        {
            
                DataTable tablaProductos = new DataTable();
                try
                {
                    conectar.abrir();
                    string consulta = "select Producto.* from Producto where id_producto = '" + producto + "'";
                    SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows == false)
                        return null;
                    tablaProductos.Load(reader);
                    conectar.cerrar();
                }
                catch (Exception) { throw; }
                return tablaProductos;
            
        }

        public bool RealizarVenta(string detalle, double subtotal, double total)
        {
            try
            {
                conectar.abrir();
                
                string consulta = "Registrar_Venta";
                SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@detalle", detalle);
                cmd.Parameters.AddWithValue("@subtotal", subtotal);
                cmd.Parameters.AddWithValue("@total", total);

                var reader = cmd.ExecuteNonQuery();
                conectar.cerrar();
                return true;
            }
            catch (Exception) { return false; }
        }
    }
}
