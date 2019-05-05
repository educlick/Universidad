using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Calificaciones
    {
        [Key]
        public int IdCalificaciones { get; set; }
        public int IdExamen { get; set; }
        public int Calificacion { get; set; }
    }
}
