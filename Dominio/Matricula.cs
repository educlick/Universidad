using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Matricula
    {
        [Key]
        public int IdMatricula { get; set; }
        public int IdCarrera { get; set; }
        public int IdAlumno { get; set; }
        public DateTime Fecha { get; set; }
    }
}
