using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DetMalla
    {
        [Key]
        [Display(Name = "Id de Detalle Malla")]
        public int IdDetmalla { get; set; }

        [Required]
        [Display(Name = "Id de Malla")]
        public int IdMalla { get; set; }
        public virtual Malla Malla { get; set; }

        [Required]
        public int IdMateria { get; set; }
        public virtual Materias Materias { get; set; }

        public virtual ICollection <Correlatividades> Correlatividades { get; set; }
    }
}
