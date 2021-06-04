using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.Modelos;

namespace Business
{
    public class B_OperacionDomicilio
    {
        public D_Domicilio dDomicilio = new D_Domicilio();

        public String InsertarDomicilio(int ID,string Calle, string Colonia, string Localidad, string Municipio, string Estado)
        {
            try
            {
                dDomicilio.idDomicilio = ID;
                dDomicilio.Calle = Calle;
                dDomicilio.Colonia = Colonia;
                dDomicilio.Localidad = Localidad;
                dDomicilio.Municipio = Municipio;
                dDomicilio.Estado = Estado;

                dDomicilio.Insertar();

       
                return "Registrado";
                
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
