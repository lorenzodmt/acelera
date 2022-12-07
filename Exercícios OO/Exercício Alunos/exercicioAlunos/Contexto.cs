using exercicioAlunos.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioAlunos
{
    internal class Contexto : DbContext
    {
        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<Cursos> Cursos { get; set; }

        public Contexto()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuider)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["EntityPostgresql2"];
            string retorno = "";

            if (settings != null)
                retorno = settings.ConnectionString;

            optionsBuider.UseNpgsql(retorno);

            optionsBuider.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cursos>()
                .HasOne(e => e.alunos)
                .WithMany(e => e.Cursos)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
