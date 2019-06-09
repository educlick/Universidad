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

       /* public System.Data.Entity.DbSet<Dominio.Turnos> Turnos { get; set; }*/
        public System.Data.Entity.DbSet<Dominio.Ciudad> Ciudad { get; set; }
        public System.Data.Entity.DbSet<Dominio.Sexo> Sexo { get; set; }
        public System.Data.Entity.DbSet<Dominio.Materias> Materias { get; set; }
        public System.Data.Entity.DbSet<Dominio.Barrio> Barrios { get; set; }
        public System.Data.Entity.DbSet<Dominio.Carreras> Carreras { get; set; }
        /*public System.Data.Entity.DbSet<Dominio.Alumno> Alumno { get; set; }
        public System.Data.Entity.DbSet<Dominio.Aulas> Aulas { get; set; }
        public System.Data.Entity.DbSet<Dominio.TipoAula> TipoAulas { get; set; }
        public System.Data.Entity.DbSet<Dominio.Profesores> Profesores { get; set; }
        public System.Data.Entity.DbSet<Dominio.Malla> Malla { get; set; }
        public System.Data.Entity.DbSet<Dominio.DetMalla> DetMallas { get; set; }
        public System.Data.Entity.DbSet<Dominio.MallaAlumnos> MallaAlumnos { get; set; }
        public System.Data.Entity.DbSet<Dominio.Correlatividades> Correlatividades { get; set; }
        public System.Data.Entity.DbSet<Dominio.Matricula> Matriculas { get; set; }
        public System.Data.Entity.DbSet<Dominio.Horarios> Horarios { get; set; }
        public System.Data.Entity.DbSet<Dominio.Inscripciones> Inscripciones { get; set; }
        public System.Data.Entity.DbSet<Dominio.HorarioExamen> HorarioExamen { get; set; }
        public System.Data.Entity.DbSet<Dominio.Examenes> Examenes { get; set; }
        public System.Data.Entity.DbSet<Dominio.Calificaciones> Calificaciones { get; set; }*/
    }
}
