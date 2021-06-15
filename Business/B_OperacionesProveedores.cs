using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.Modelos;
using System.Data;
using System.Data.SqlClient;

namespace Business
{
    public class B_OperacionesProveedores
    {
        public D_Proveedor dProveedor = new D_Proveedor();

        public String InsertarProveedores(string Nombre, string correoE, string telefono, int direccion)
        {
            try
            {
                dProveedor.Nombre = Nombre;
                dProveedor.CorreoE = correoE;
                dProveedor.Telefono = telefono;
                dProveedor.fk_Direccion = direccion;

                dProveedor.Insertar();
                if (dProveedor.Insertar())
                {
                    return "El proveedor ha sido registrado correctamente";
                }
                else
                {
                    return "El proveedor no ha sido registrado";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public String ActualizarProveedores(int Id, string Nombre, string correoE, string telefono, int fk_direccion)
        {
            try
            {
                dProveedor.id_Proveedor = Id;
                dProveedor.Nombre = Nombre;
                dProveedor.CorreoE = correoE;
                dProveedor.Telefono = telefono;
                dProveedor.fk_Direccion = fk_direccion;

                if (dProveedor.Actualizar(Id))
                {
                     return "El proveedor se actualizo correctamente";
                }
                else
                {
                     return "No se actualizo ";
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public DataTable Buscar_Proveedores()
        {
            try
            {
                return dProveedor.BuscarProveedor();
            }
            catch (Exception)
            {

                throw;
            }
        }  
    }
}
