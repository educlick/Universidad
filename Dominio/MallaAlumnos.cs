using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class MallaAlumnos
    {
        public int IdMallaalu { get; set; }
        public int IdMalla { get; set; }
        public int IdAlumno { get; set; }
        public DateTime InicioValidez { get; set; }
        public DateTime FinValidez { get; set; }
    }
}
