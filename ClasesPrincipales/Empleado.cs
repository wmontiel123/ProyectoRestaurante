using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPrincipales
{
    public class Empleado
    {

        public string Nombre { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public string Telefono { get; set; }

        public static List<Empleado> listaEmpleados = new List<Empleado>();

        public static void AgregarEmpleado(Empleado c)
        {
            listaEmpleados.Add(c);
        }


        public static void EliminarEmpleado(Empleado p)
        {
            listaEmpleados.Remove(p);
        }

        public static List<Empleado> ObtenerEmpleadoes()
        {
            return listaEmpleados;
        }

        public override string ToString()
        {
            return ruc;
        }


    }
}
