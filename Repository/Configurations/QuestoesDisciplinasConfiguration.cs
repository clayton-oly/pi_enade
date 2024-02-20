using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEnade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEnade.Repository.Configurations
{
    public class QuestoesDisciplinasConfiguration : IEntityTypeConfiguration<QuestoesDisciplinas>
    {
        public void Configure(EntityTypeBuilder<QuestoesDisciplinas> builder)
        {
            builder
                .ToTable("QuestoesDisciplinas")
                .HasKey(x => x.Id);

            builder
               .HasOne(x => x.Questoes)
               .WithMany(x => x.QuestoesDisciplinas)
               .HasForeignKey(x => x.IdQuestao);


            builder
                .HasOne(x => x.Disciplinas)
                .WithMany(x => x.QuestoesDisciplinas)
                .HasForeignKey(x => x.IdDisciplina);
        }
    }
}
