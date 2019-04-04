using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoAula
    {
        [Key]
        public int IdTpaula { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}", MinimumLength = 2)]
        public string Tipo { get; set; }

        [Required]
        public int Capacidad { get; set; }

        [StringLength(1, ErrorMessage = "El número de caracteres de {0} debe ser al menos {1}", MinimumLength = 1)]
        public string Wifi { get; set; }

        //public virtual ICollection <Aulas> Aulas { get; set; }
    }
}
