using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEnade.Models
{
    public class QuestoesDisciplinas : Base
    {
        public int IdQuestao { get; set; }
        public QuestaoGabarito Questoes { get; set; }
        public int IdDisciplina { get; set; }
        public Disciplinas Disciplinas { get; set; }

        [NotMapped]
        public string NomeDisciplina { get; set; }

    }
}
