using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Malla
    {
        [Key]
        public int IdMalla { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}", MinimumLength = 2)]
        [Display(Name = "Nombre de Malla")]
        public string NomMalla { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime InicioValidez { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime FinValidez { get; set; }

        public virtual ICollection <MallaAlumnos> MallaAlunmos  { get; set; }
        public virtual ICollection <DetMalla> DetMallas { get; set; }

    }
}
