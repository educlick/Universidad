using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Materias")]
    public class Materias
    {
        [Key]
        [Display(Name = "Id de Materia")]
        public int IdMateria { get; set; }
        [Display(Name = "Descripción")]
        public char Descripcion { get; set; }

        public virtual ICollection<Horarios> Horarios { get; set; }
        public virtual ICollection<Correlatividades> Correlatividad { get; set; }
        public virtual ICollection<HorarioExamen> HorarioExamen { get; set; }
        public virtual ICollection<DetMalla> DetMalla { get; set; }
    }
}
