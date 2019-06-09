using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sexo
    {
        [Key]
        public int IdSexo { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        [StringLength(30, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}", MinimumLength = 2)]
        public string Descripcion { get; set; }
        public virtual ICollection <Alumno> Alumno { get; set; }
        public virtual ICollection <Profesores> Profesores { get; set; }
    }
}
