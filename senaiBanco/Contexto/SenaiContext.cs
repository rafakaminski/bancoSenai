using Microsoft.EntityFrameworkCore;
using senaiBanco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senaiBanco.Contexto
{
    internal class SenaiContext : DbContext
    {
        public DbSet<Escola> Escola { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Professor> Professor { get; set;}
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Aluno> Alunos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server = 127.0.0.1; Port = 5432; Database = postgres; User Id = postgres; Password = postgres;");
        }
    }
}
