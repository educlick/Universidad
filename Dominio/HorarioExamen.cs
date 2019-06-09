using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("HorarioExamen")]
    public class HorarioExamen
    {
        [Key]
        public int HorarioExamenId { get; set; }

        [Display(Name = "Id de Aula")]
        public int AulaId { get; set; }
        public virtual Aulas Aulas { get; set; }

        [Display(Name = "Id de Profesor")]
        public int ProfesorId { get; set; }
        public virtual Profesores Profesor { get; set; }

        [Display(Name = "Id de Materia")]
        public int MateriaId { get; set; }
        public virtual Materias Materiase { get; set; }

        [Display(Name = "Id de Turno")]
        public int TurnoId { get; set; }
        public virtual Turnos Turnos { get; set; }

        [Display(Name = "Fecha de Examen")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Fecha { get; set; }

        public virtual ICollection<Examenes> Examens { get; set; }
        
    }
}
