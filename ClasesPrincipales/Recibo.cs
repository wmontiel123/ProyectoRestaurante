using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPrincipales
{
    class Recibo
    {
        public Cliente cliente { get; set; }
        public int nro_recibo { get; set; }
        public DateTime Fecha_recibo { get; set; }
        public Double Total { get; set; }
    }
}
