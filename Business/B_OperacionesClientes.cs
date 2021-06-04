using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.Modelos ;

namespace Business
{
    public class B_OperacionesClientes
    {
        public D_Cliente dCiente = new D_Cliente();

        public string InsertarClientes(string NombreC, string Tetefono, int direccion)
        {
            try
            {
                dCiente.NombreC = NombreC;
                dCiente.telefono = Tetefono;
                dCiente.Direccion = direccion;

                dCiente.Insertar();
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

        public string InsertarClientes(int id, string nombreC, string telefono, int  direccion)
        {
            dCiente.IdCliente= id;
            try
            {
                dCiente.IdCliente = id;
                dCiente.NombreC = nombreC;
                dCiente.telefono = telefono;
                dCiente.Direccion = direccion;

                dCiente.Insertar();
                if (dCiente.Insertar())
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
    }
    }
}
