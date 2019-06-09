using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class MallaAlumnos
    {
        [Key]
        [Display(Name = "Id de Mala Alumno")]
        public int IdMallaalu { get; set; }

        [Required]
        [Display(Name = "Id de Malla")]
        public int IdMalla { get; set; }
        public virtual Malla Malla { get; set; }

        [Required]
        [Display(Name = "Id de Alumno")]
        public int IdAlumno { get; set; }
        public virtual Alumno Alumno { get; set; }

        [Display(Name = "Fecha Inicio de Validez")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime InicioValidez { get; set; }

        [Display(Name = "Fecha Fin Validez")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime FinValidez { get; set; }

        public virtual ICollection<Inscripciones> Inscripciones { get; set; }
    }
}
