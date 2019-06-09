using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Examenes
    {
        [Key]
        [Display(Name = "Id de Examen")]
        public int IdExamen { get; set; }
        [Display(Name = "Id de Inscripción")]
        public int IdInscripcion { get; set; }
        [Display(Name = "Id de Horario de Exámen")]
        public int HorExamen { get; set; }
        public virtual HorarioExamen HorarioExamen { get; set; }
        [Display(Name = "Fecha de Examen")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Fecha { get; set; }

        public virtual ICollection<Calificaciones> Calificaciones { get; set; }
        
    }
}
