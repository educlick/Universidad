using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoAula
    {
        public int IdTpaula { get; set; }
        public string Tipo { get; set; }
        public int Capacidad { get; set; }
        public Boolean Wifi { get; set; }
    }
}
