using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEnade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEnade.Repository.Configurations
{
    public class CursoDisciplinaConfiguration : IEntityTypeConfiguration<CursoDisciplina>
    {
        public void Configure(EntityTypeBuilder<CursoDisciplina> builder)
        {
            builder
                .ToTable("CursoDisciplina")
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.Curso)
                .WithMany(x => x.CursoDisciplina)
                .HasForeignKey(x => x.IdCurso);


            builder
                .HasOne(x => x.Disciplinas)
                .WithMany(x => x.CursoDisciplina)
                .HasForeignKey(x => x.IdDisciplina);
        }
    }
}
