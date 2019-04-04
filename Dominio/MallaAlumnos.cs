using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class MallaAlumnos
    {
        [Key]
        public int IdMallaalu { get; set; }

        [Required]
        public int IdMalla { get; set; }
        public virtual Malla Malla { get; set; }

        [Required]
        public int IdAlumno { get; set; }


        public DateTime InicioValidez { get; set; }

        public DateTime FinValidez { get; set; }
    }
}
