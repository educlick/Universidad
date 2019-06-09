using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Aulas")]
    public class Aulas
    {
        [Key]
        [Display(Name = "Id de Aula")]
        public int AulaId { get; set; }
        [Required]
        [Display(Name = "Id de Tipo de Aula")]
        public int TipoAulaId { get; set; }
        public virtual TipoAula TipoAula { get; set; }
        [Required]
        [Display(Name = "Descripción")]
        public char Descripcion { get; set; }
        [Display(Name = "Edificio")]
        public char Edificio { get; set; }
        [Display(Name = "Piso")]
        public char Piso { get; set; }
        [Display(Name = "Georeferencia")]
        public char georeferencia { get; set; }

        public virtual ICollection<Horarios> Horarios { get; set; }
        public virtual ICollection<HorarioExamen> HorarioExamen { get; set; }
        

    }
}
