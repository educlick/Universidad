﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Correlatividades
    {
        [Key]
        public int IdCorredet { get; set; }

        [Required]
        [Display(Name = "Seleccione el detalle malla")]
        public int IdDetmalla { get; set; }
        public virtual DetMalla DetMalla { get; set; }

        [Display(Name = "Orden")]
        public int Orden_1 { get; set; }

        [Display(Name = "Seleccione la materia")]
        public int IdMateria { get; set; }
        public virtual Materias Materias { get; set; }

    }
}
