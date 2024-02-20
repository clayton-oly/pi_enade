using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEnade.Models
{
    public class Cursos : Base
    {
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public List<CursoDisciplina> CursoDisciplina { get; set; }
        public Provas Prova { get; set; }
    }
}
