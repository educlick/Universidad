using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Horarios")]
    public class Horarios
    {
        [Key]
        [Display(Name = "Id de Horario")]
        public int HorarioId { get; set; }
        [Required]
        [Display(Name = "Id de Aula")]
        public int AulaId { get; set; }
        public virtual Aulas Aulas { get; set; }
        [Required]
        [Display(Name = "Id de Profesor")]
        public int ProfesorId { get; set; }
        public virtual Profesores Profesor { get; set; }
        [Required]
        [Display(Name = "Id de Materia")]
        public int MateriaId { get; set; }
        public virtual Materias Materias { get; set; }
        [Required]
        [Display(Name = "Id de Turno")]
        public int TurnoId { get; set; }
        public virtual Turnos Turnos { get; set; }
        [Display(Name = "Cupo")]
        public int Cupo { get; set; }

        public virtual ICollection<Inscripciones> Inscripcions { get; set; }
    }
}
