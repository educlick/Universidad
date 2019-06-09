using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class HorarioExamen
    {
        [Key]
        public int IdHorarioExamen { get; set; }
        [Display(Name = "Id de Aula")]
        public int IdAula { get; set; }
        public virtual Aulas Aulas { get; set; }
        [Display(Name = "Id de Profesor")]
        public int IdProfesor { get; set; }
        public virtual Profesores Profesores { get; set; }
        [Display(Name = "Id de Materia")]
        public int IdMateria { get; set; }
        public virtual Materias Materias { get; set; }
        [Display(Name = "Id de Turno")]
        public int IdTurno { get; set; }
        public virtual Turnos Turnos { get; set; }
        [Display(Name = "Fecha de Examen")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Fecha { get; set; }

        public virtual ICollection<Examenes> Examenes { get; set; }
    }
}
