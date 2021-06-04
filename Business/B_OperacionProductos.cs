using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.Modelos;

namespace Business
{
    public class B_OperacionProductos
    {
        public D_Productos dProductos = new D_Productos();

        public String InsertarProductos (string NombreP, string Codigo, string Marca, int cantidad, string Color, float PrecioCom,float precioVent, string Descripccion)
        {
            try
            {
                dProductos.NombreP = NombreP;
                dProductos.Codigo = Codigo;
                dProductos.Marca = Marca;
                dProductos.Cantidad = cantidad;
                dProductos.Color = Color;
                dProductos.PrecioComp = PrecioCom;
                dProductos.PrecioVent = precioVent;
                dProductos.Descripcion = Descripccion;

                dProductos.Insertar();
                if (dProductos.Insertar())
                {
                    return "El producto ha sido registrado correctamente";
                }
                else
                {
                    return "El producto no ha sido registrado";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public String ActualizarProductos(int ID, string Codigo, string Marca, int cantidad, string Color, float PrecioCom, float precioVent, string Descripccion)
        {
            dProductos.idProducto = ID;
            dProductos.Codigo = Codigo;
            dProductos.Marca = Marca;
            dProductos.Cantidad = cantidad;
            dProductos.Color = Color;
            dProductos.PrecioComp = PrecioCom;
            dProductos.PrecioVent = precioVent;
            dProductos.Descripcion = Descripccion;

            dProductos.Actualizar();
            if (dProductos.Actualizar(ID))
            {
                return "El producto ha sido actualizado correctamente";
            }
            else
            {
                return "El producto no ha sido actualizado";
            }

        }
    }
}
