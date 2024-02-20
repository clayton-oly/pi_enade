using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEnade.Models
{
    public class Provas : Base
    {
        [Display(Name = "Cursos")]
        public int IdCurso { get; set; }
        public Cursos Cursos { get; set; }
        public int Ano { get; set; }
        public int Edicao { get; set; }
        public List<QuestaoGabarito> QuestoesGabarito { get; set; }
    }
}
