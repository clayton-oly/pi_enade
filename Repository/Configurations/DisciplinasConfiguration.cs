using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEnade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEnade.Repository.Configurations
{
    public class DisciplinasConfiguration : IEntityTypeConfiguration<Disciplinas>
    {
        public void Configure(EntityTypeBuilder<Disciplinas> builder)
        {
            builder
                .ToTable("Disciplinas")
                .HasKey(x => x.Id);           
        }
    }
}
