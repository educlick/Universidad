using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Matricula")]
    public class Matricula
    {
        [Key]
        [Display(Name = "Id de Matricula")]
        public int MatriculaId { get; set; }
        [Required]
        [Display(Name = "Id de Carrera")]
        public int CarreraId { get; set; }
        public virtual Carreras Carreras { get; set; }

        [Display(Name = "Id de Alumno")]
        public int AlumnoId { get; set; }
        public virtual Alumno Alumno { get; set; }

        [Display(Name = "Fecha de Matricula")]
        public DateTime Fecha { get; set; }

        public virtual ICollection<Inscripciones> Inscripciones { get; set; }
    }
}
