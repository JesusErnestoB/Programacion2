using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.Modelos;
using System.Data;

namespace Business
{
    public class B_OperacionEmpleadosAgregar
    {
        public D_Empleados dEmpleados = new D_Empleados();

        public String InsertarEmpleados(string NombreE, string ApellidoPE, string ApellidoME, string Sexo, int edad, int Domicilio)
        {
            try
            {
                dEmpleados.NombreEm = NombreE;
                dEmpleados.ApellidoPE = ApellidoPE;
                dEmpleados.ApellidoME = ApellidoME;
                dEmpleados.Sexo = Sexo;
                dEmpleados.Edad = edad;
                dEmpleados.Direccion = Domicilio;

                dEmpleados.Insertar();
                if (dEmpleados.Insertar())
                {
                    return "El Empleado ha sido registrado correctamente";
                }
                else
                {
                    return "El Emplaeado no ha sido registrado correctamente";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public String ActualizarEmpleados(int ID, string NombreE, string ApellidoPE, string ApellidoME, string Sexo, int edad, int Domicilio)
        {
            try
            {
                dEmpleados.idEmpleados = ID;
                dEmpleados.NombreEm = NombreE;
                dEmpleados.ApellidoPE = ApellidoPE;
                dEmpleados.ApellidoME = ApellidoME;
                dEmpleados.Sexo = Sexo;
                dEmpleados.Edad = edad;
                dEmpleados.Direccion = Domicilio;

                if (dEmpleados.Actualizar(ID))
                {
                    return "El empleado se ha actualizado";
                }
                else
                {
                    return "El empleado no se ha actualizado";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable Buscar_Empleados()
        {
            try
            {
                return dEmpleados.BuscarEmpleados();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
