using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carreras
    {
        [Key]
        public int IdCarrera { get; set; }

        public string Descripcion { get; set; }
    }
}
