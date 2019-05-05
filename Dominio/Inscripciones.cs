using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Inscripciones
    {
        [Key]
        public int IdInscripcion { get; set; }

        [Required]
        [Display(Name = "Id de Alumno")]
        public int IdAlumno { get; set; }
        [Required]
        [Display(Name = "Id de Matricula")]
        public int IdMatricula { get; set; }
        [Required]
        [Display(Name = "Id de Malla")]
        public int IdMallaAlum { get; set; }
        [Required]
        [Display(Name = "Id de Horario")]
        public int IdHorario { get; set; }
        [Required]
        [Display(Name = "Fecha de Inscripción")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Fecha { get; set; }
        
    }
}
