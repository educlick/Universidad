using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Horarios
    {
        [Key]
        public int IdHorario { get; set; }
        public int IdAula { get; set; }
        public virtual Aulas Aulas { get; set; }
        public int IdProfesor { get; set; }
        public virtual Profesores Profesores { get; set; }
        public int IdMateria { get; set; }
        public virtual Materias Materias { get; set; }
        public int IdTurno { get; set; }
        public virtual Turnos Turnos { get; set; }
        public int Cupo { get; set; }

        public virtual ICollection<Inscripciones> Inscripciones { get; set; }
    }
}
