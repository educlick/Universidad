using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Inscripciones")]
    public class Inscripciones
    {
        [Key]
        public int IdInscripcion { get; set; }
                
        [Display(Name = "Id de Alumno")]
        public int AlumnoId { get; set; }
        public virtual Alumno Alumnoes { get; set; }
        
        [Display(Name = "Id de Matricula")]
        public int MatriculaId { get; set; }
        public virtual Matricula Matriculaes { get; set; }
        
        [Display(Name = "Id de Malla")]
        public int MallaaluId { get; set; }
        public virtual MallaAlumnos MallaAlumnoes { get; set; }

        [Display(Name = "Id de Horario")]
        public int HorarioId { get; set; }
        public virtual Horarios Horarioes { get; set; }


        [Display(Name = "Fecha de Inscripción")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Fecha { get; set; }

        public virtual ICollection<Examenes> Examenes { get; set; }
    }
}
