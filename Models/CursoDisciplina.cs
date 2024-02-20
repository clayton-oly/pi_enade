using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEnade.Models
{
    public class CursoDisciplina : Base
    {
        public int IdCurso { get; set; }
        public Cursos Curso { get; set; }
        public int IdDisciplina { get; set; }
        public Disciplinas Disciplinas { get; set; }
    }
}
