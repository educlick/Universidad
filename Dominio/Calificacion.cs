using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Calificaciones")]
    public class Calificaciones
    {
        [Key]
        public int CalificacionId { get; set; }
        public int ExamenId { get; set; }
        public virtual Examenes Examenes { get; set; }
        public int Calification { get; set; }
        
    }
}
