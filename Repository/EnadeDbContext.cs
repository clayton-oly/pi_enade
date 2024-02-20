using Microsoft.EntityFrameworkCore;
using ProjetoEnade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ProjetoEnade.Repository
{
    public class EnadeDbContext : DbContext
    {
        public EnadeDbContext(DbContextOptions<EnadeDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Provas> Provas { get; set; }
        public DbSet<Disciplinas> Disciplinas { get; set; }
        public DbSet<CursoDisciplina> CursoDisciplina { get; set; }
        public DbSet<QuestaoGabarito> QuestaoGabarito { get; set; }
        public DbSet<QuestoesDisciplinas> QuestoesDisciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
