using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEnade.Models
{
    public class QuestaoGabarito : Base
    {
        public int IdProva { get; set; }

        [Display(Name = "Prova")]
        [NotMapped]
        public string DescricaoProva { get; set; }
        public Provas Provas { get; set; }
        public string Enunciado { get; set; }

        [Display(Name = "Tipo da Questão")]
        public int TipoProva { get; set; }

        [NotMapped]
        public string DescricaoTipoProva { get; set; }

        [Display(Name = "Dificuldade da Questão")]
        public int DificuldadeQuestao { get; set; }

        [NotMapped]
        public string DescricaoDificuldadeQuestao { get; set; }

        [Display(Name = "Resposta A")]
        public string RespostaA { get; set; }

        [Display(Name = "Resposta B")]
        public string RespostaB { get; set; }

        [Display(Name = "Resposta C")]
        public string RespostaC { get; set; }

        [Display(Name = "Resposta D")]
        public string RespostaD { get; set; }

        [Display(Name = "Resposta E")]
        public string RespostaE { get; set; }

        [Display(Name = "Resposta Correta")]
        public int RespostaCorreta { get; set; }

        [NotMapped]
        public string DescricaoRespostaCorreta { get; set; }

        [Display(Name = "Disciplinas")]
        public List<QuestoesDisciplinas> QuestoesDisciplinas { get; set; }

        [Display(Name = "Disciplinas")]
        [Required]
        [NotMapped]
        public List<int> MultiDisciplinas { get; set; }

        [NotMapped]
        public string DescricaoDisciplinas { get; set; }

        [Display(Name = "Resposta Dissertativa")]
        public string RespostaDissertativa { get; set; }

        [Display(Name = "Imagem do Enunciado")]
        public byte[] EnunciadoImage { get; set; }

        [NotMapped]
        public string EnunciadoImageBase64 { get; set; }

        [Display(Name = "Imagem da Resposta A")]
        public byte[] RespostaAImage { get; set; }

        [NotMapped]
        public string RespostaAImageBase64 { get; set; }

        [Display(Name = "Imagem da Resposta B")]
        public byte[] RespostaBImage { get; set; }

        [NotMapped]
        public string RespostaBImageBase64 { get; set; }

        [Display(Name = "Imagem da Resposta C")]
        public byte[] RespostaCImage { get; set; }

        [NotMapped]
        public string RespostaCImageBase64 { get; set; }

        [Display(Name = "Imagem da Resposta D")]
        public byte[] RespostaDImage { get; set; }

        [NotMapped]
        public string RespostaDImageBase64 { get; set; }

        [Display(Name = "Imagem da Resposta E")]
        public byte[] RespostaEImage { get; set; }

        [NotMapped]
        public string RespostaEImageBase64 { get; set; }
    }
}
