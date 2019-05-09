using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Matricula
    {
        [Key]
        [Display(Name = "Id de Matricula")]
        public int IdMatricula { get; set; }
        [Required]
        [Display(Name = "Id de Carrera")]
        public int IdCarrera { get; set; }
        public virtual Carreras Carreras { get; set; }
        [Required]
        [Display(Name = "Id de Alumno")]
        public int IdAlumno { get; set; }
        public virtual Alumno Alumno { get; set; }
        [Display(Name = "Fecha de Matricula")]
        public DateTime Fecha { get; set; }

        public virtual ICollection<Inscripciones> Inscripciones { get; set; }
    }
}
