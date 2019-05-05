using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Horarios
    {
        public int IdHorario { get; set; }
        public int IdAula { get; set; }
        public int IdProfesor { get; set; }
        public int IdMateria { get; set; }
        public int IdTurno { get; set; }
        public virtual Turnos Turnos { get; set; }
        public int Cupo { get; set; }
    }
}
