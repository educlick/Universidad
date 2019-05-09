using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Profesores
    {
        [Key]
        [Display(Name = "Id de Profesores")]
        public int IdProfesor { get; set; }
        [Required]
        [Display(Name = "Cédula")]
        public char Cedula { get; set; }
        [Display(Name = "Nombre")]
        public char Nombre { get; set; }
        [Display(Name = "Apellido")]
        public char Apellido { get; set; }
        [Required]
        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime FechaNac { get; set; }
        [Required]
        [Display(Name = "Sexo")]
        public int IdSexo { get; set; }
        public virtual Sexo Sexo { get; set; }
        [Display(Name = "Barrio")]
        public int IdBarrio { get; set; }
        public virtual Barrio Barrio { get; set; }
        [Display(Name = "Ciudad")]
        public int IdCiudad { get; set; }
        public virtual Ciudad Ciudad { get; set; }
        [Display(Name = "Teléfono")]
        public char Telefono { get; set; }
        [Display(Name = "Teléfono Móvil")]
        public char TelefonoMovil { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [Display(Name = "Mail")]
        public char Mail { get; set; }

        public virtual ICollection<Horarios> Horarios  { get; set; }
        public virtual ICollection<HorarioExamen> HorarioExamen { get; set; }
    }
}
