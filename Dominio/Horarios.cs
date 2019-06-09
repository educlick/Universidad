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
        [Display(Name = "Id de Horario")]
        public int IdHorario { get; set; }
        [Required]
        [Display(Name = "Id de Aula")]
        public int IdAula { get; set; }
        public virtual Aulas Aulas { get; set; }
        [Required]
        [Display(Name = "Id de Profesor")]
        public int IdProfesor { get; set; }
        public virtual Profesores Profesores { get; set; }
        [Required]
        [Display(Name = "Id de Materia")]
        public int IdMateria { get; set; }
        public virtual Materias Materias { get; set; }
        [Required]
        [Display(Name = "Id de Turno")]
        public int IdTurno { get; set; }
        public virtual Turnos Turnos { get; set; }
        [Display(Name = "Cupo")]
        public int Cupo { get; set; }

        public virtual ICollection<Inscripciones> Inscripciones { get; set; }
    }
}
