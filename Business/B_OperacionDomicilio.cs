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

        public String InsertarDomicilio(string Calle, string Colonia, string Localidad, string Municipio, string Estado)
        {
            try
            {

                dDomicilio.Calle = Calle;
                dDomicilio.Colonia = Colonia;
                dDomicilio.Localidad = Localidad;
                dDomicilio.Municipio = Municipio;
                dDomicilio.Estado = Estado;

                if (dDomicilio.Insertar())
                {

                    return dDomicilio.idDomicilio;
                }
                else
                {
                    return "El domicilio no ha sido registrado";
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        public String ActualizarDomicilio(string idDomicilio, string Calle, string Colonia, string Localidad, string Municipio, string Estado)
        {
            try
            {
                dDomicilio.idDomicilio = idDomicilio;
                dDomicilio.Calle = Calle;
                dDomicilio.Colonia = Colonia;
                dDomicilio.Localidad = Localidad;
                dDomicilio.Municipio = Municipio;
                dDomicilio.Estado = Estado;

                if (dDomicilio.Actualizar())
                {

                    return dDomicilio.idDomicilio;
                }
                else
                {
                    return "El domicilio no ha sido registrado";
                }

            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}