using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("DetMalla")]
    public class DetMalla
    {
        [Key]
        [Display(Name = "Id de Detalle Malla")]
        public int DetmallaId { get; set; }

        [Required]
        [Display(Name = "Id de Malla")]
        public int MallaId { get; set; }
        public virtual Malla Malla { get; set; }

        [Required]
        [Display(Name = "Id de Materia")]
        public int MateriaId { get; set; }
        public virtual Materias Materias { get; set; }

        public virtual ICollection <Correlatividades> Correlatividades { get; set; }
    }
}
