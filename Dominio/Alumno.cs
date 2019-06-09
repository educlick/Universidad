using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Alumno")]
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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Sexo")]
        public int IdSexo { get; set; }
        public virtual Sexo Sexo { get; set; }

        [Display(Name = "Telefono")]
        [DataType(DataType.PhoneNumber)]
        public int Telefono { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}", MinimumLength = 6)]
        public string Mail { get; set; }

        [Display(Name = "Celular")]
        [DataType(DataType.PhoneNumber)]
        public int Telefono_Movil { get; set; }
                
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}", MinimumLength = 2)]
        public string Direccion { get; set; }

        [Display(Name = "Barrio")]
        public int IdBarrio { get; set; }
        public virtual Barrio Barrio { get; set; }

        [Display(Name = "Ciudad")]
        public int IdCiudad { get; set; }
        public virtual Ciudad Ciudad { get; set; }

        public virtual ICollection<Matricula> Matricula { get; set; }
        public virtual ICollection<MallaAlumnos> MallaAlumnos { get; set; }
        public virtual ICollection<Inscripciones> Inscripcion { get; set; }
    }
}
