using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.Modelos ;
using System.Data;
using System.Data.SqlClient;

namespace Business
{
    public class B_OperacionesClientes
    {
        public D_Cliente dCiente = new D_Cliente();

        public string InsertarClientes(string NombreC, string Tetefono, string fk_direccion)
        {
            try
            {
                dCiente.NombreC = NombreC;
                dCiente.telefono = Tetefono;
                dCiente.Direccion = fk_direccion;

                
                if (dCiente.Insertar())
                {
                    return "El cliente ha sido registrado correctamente";
                }
                else
                {
                    return "El cliente no ha sido registrado";

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string  ActualizarClientes(int id, string nombreC, string telefono)
        {
            try
            {
                dCiente.IdCliente = id;
                dCiente.NombreC = nombreC;
                dCiente.telefono = telefono;
                

                if (dCiente.Actualizar())
                {
                    return "El cliente ha sido actualizado correctamente";
                }
                else
                {
                    return "El cliente no ha sido Actualizado";

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable Buscar_Clientes()
        {
            try
            {
                return dCiente.BuscarCliente();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataTable Buscar_Clientes_especifico(string nombre)
        {
            try
            {
                return dCiente.BuscarClienteespecifico( nombre);
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}