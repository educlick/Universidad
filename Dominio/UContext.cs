using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class UContext:DbContext
    {
        public UContext ()
            :base("DefaultConnection")
        {

        }

        public DbSet<Dominio.Turnos> Turnos { get; set; }
    }
}
