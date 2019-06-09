using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turnos
    {
        [Key]
        [Display(Name = "Id de Turno")]
        public int IdTurno { get; set; }
        [Required]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        public virtual ICollection<Horarios> Horarios { get; set; }
        public virtual ICollection<HorarioExamen> HorarioExamen  { get; set; }
    }
}
