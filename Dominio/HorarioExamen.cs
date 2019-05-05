using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class HorarioExamen
    {
        [Key]
        public int IdHorarioExamen { get; set; }
        public int IdAula { get; set; }
        public int IdProfesor { get; set; }
        public int IdMateria { get; set; }
        public int IdTurno { get; set; }
        [Display(Name = "Fecha de Examen")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Fecha { get; set; }

        public virtual ICollection<Examenes> Examenes { get; set; }
    }
}
