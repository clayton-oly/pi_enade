using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEnade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEnade.Repository.Configurations
{
    public class QuestaoGabaritoConfiguration : IEntityTypeConfiguration<QuestaoGabarito>
    {
        public void Configure(EntityTypeBuilder<QuestaoGabarito> builder)
        {
            builder
                .ToTable("QuestaoGabarito")
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.Provas)
                .WithMany(x => x.QuestoesGabarito)
                .HasForeignKey(x => x.IdProva);
        }
    }
}
