using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEnade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEnade.Repository.Configurations
{
    public class ProvasConfiguration : IEntityTypeConfiguration<Provas>
    {
        public void Configure(EntityTypeBuilder<Provas> builder)
        {
            builder
                .ToTable("Provas")
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.Cursos)
                .WithOne(x => x.Prova)
                .HasForeignKey<Provas>(x => x.IdCurso);
        }
    }
}
