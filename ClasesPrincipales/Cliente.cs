using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPrincipales
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public string Telefono { get; set; }

        public static List<Cliente> listaClientes = new List<Cliente>();

        public static void AgregarCliente(Cliente c)
        {
            listaClientes.Add(c);
        }


        public static void EliminarCliente(Cliente p)
        {
            listaClientes.Remove(p);
        }

        public static List<Cliente> ObtenerClientees()
        {
            return listaClientes;
        }

        public override string ToString()
        {
            return ruc;
        }


    }
}
