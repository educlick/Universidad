using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Examenes")]
    public class Examenes
    {
        [Key]
        [Display(Name = "Id de Examen")]
        public int ExamenId { get; set; }

        [Display(Name = "Id de Inscripción")]
        public int InscripcionId { get; set; }
        public virtual Inscripciones Inscripciones { get; set; }

        [Display(Name = "Id de Horario de Exámen")]
        public int HorarioExamenId { get; set; }
        public virtual HorarioExamen HorarioExamenes { get; set; }

        [Display(Name = "Fecha de Examen")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Fecha { get; set; }

        public virtual ICollection<Calificaciones> Calificacions { get; set; }
        
    }
}
