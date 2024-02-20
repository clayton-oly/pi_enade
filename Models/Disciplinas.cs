using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEnade.Models
{
    public class Disciplinas : Base
    {
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public Cursos Curso { get; set; }
        public List<CursoDisciplina> CursoDisciplina { get; set; }
        public List<QuestoesDisciplinas> QuestoesDisciplinas { get; set; }

    }
}
