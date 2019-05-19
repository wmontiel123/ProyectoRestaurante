using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPrincipales
{
    public class Plato
    {
        public string Nombre { get; set; }
        public string categoria { get; set; }
        public double Precio { get; set; }
        public double descuento{ get; set; }

        public static List<Plato> listaPlatos = new List<Plato>();

        public static void AgregarPlato(Plato c)
        {
            listaPlatos.Add(c);
        }


        public static void EliminarPlato(Plato p)
        {
            listaPlatos.Remove(p);
        }

        public static List<Plato> ObtenerPlatoes()
        {
            return listaPlatos;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
