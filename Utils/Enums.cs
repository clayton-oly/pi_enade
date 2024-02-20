using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEnade.Utils
{
    public static class Enums
    {
        public enum DificuldadeDaQuestao
        {
            [Description("Fácil")]
            [Display(Name = "Fácil")]
            Facil = 1,
            [Description("Médio")]
            [Display(Name = "Médio")]
            Medio = 2,
            [Description("Difícil")]
            [Display(Name = "Difícil")]
            Dificil = 3
        }

        public enum RespostaCerta
        {
            [Description("A")]
            [Display(Name = "A")]
            A = 1,
            [Description("B")]
            [Display(Name = "B")]
            B = 2,
            [Description("C")]
            [Display(Name = "C")]
            C = 3,
            [Description("D")]
            [Display(Name = "D")]
            D = 4,
            [Description("E")]
            [Display(Name = "E")]
            E = 5
        }

        public enum TipoDaProva
        {
            [Description("Dissertativa")]
            [Display(Name = "Dissertativa")]
            Dissertativa = 1,

            [Description("Múltipla Escolha")]
            [Display(Name = "Múltipla Escolha")]
            MultiplaEscolha = 2
        }
    }
}
