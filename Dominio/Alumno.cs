using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Alumno
    {
        [Key]
        public int IdAlumno { get; set; }
        
        [Required]
        [StringLength(15, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}", MinimumLength = 2)]
        public string Cedula { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}", MinimumLength = 2)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}", MinimumLength = 2)]
        public string Apellido { get; set; }

        [Display(Name ="Fecha de Nacimiento")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime FechaNacimiento { get; set; }

        public int Sexo { get; set; }

        [Display(Name = "Telefono")]
        [DataType(DataType.PhoneNumber)]
        public int Telefono { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {6}", MinimumLength = 6)]
        public string Mail { get; set; }

        [Display(Name = "Celular")]
        [DataType(DataType.PhoneNumber)]
        public int Telefono_Movil { get; set; }
                
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}", MinimumLength = 2)]
        public string Direccion { get; set; }

        public int IdBarrio { get; set; }

        public int IdCiudad { get; set; }


    }
}
