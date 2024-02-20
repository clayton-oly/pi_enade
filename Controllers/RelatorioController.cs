using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoEnade.Models;
using ProjetoEnade.Repository;
using ProjetoEnade.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEnade.Controllers
{
    public class RelatorioController : Controller
    {
        private readonly EnadeDbContext _context;

        public RelatorioController(EnadeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var provas = from prova in _context.Provas.ToList()
                         join curso in _context.Cursos.ToList() on prova.IdCurso equals curso.Id
                         select new
                         {
                             Id = prova.Id,
                             DescricaoCompleta = $"Ano: {prova.Ano} - Curso: {curso.Nome} - Edição: {prova.Edicao}"
                         };

            ViewData["DetalhesProva"] = new SelectList(provas, "Id", "DescricaoCompleta", null);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Excel(RelatorioModel relatorioModel)
        {
            var dadosRelatorio = (from questoes in _context.QuestaoGabarito.ToList()
                                  join provas in _context.Provas.ToList() on questoes.IdProva equals provas.Id
                                  join cursos in _context.Cursos.ToList() on provas.IdCurso equals cursos.Id
                                  where
                                  (relatorioModel.MultiProvas == null || relatorioModel.MultiProvas.Contains(questoes.IdProva)) &&
                                  (questoes.TipoProva == relatorioModel.TipoProva || relatorioModel.TipoProva == 0) &&
                                  (questoes.DificuldadeQuestao == relatorioModel.DificuldadeQuestao || relatorioModel.DificuldadeQuestao == 0) &&
                                  (questoes.RespostaCorreta == relatorioModel.RespostaCorreta || relatorioModel.RespostaCorreta == 0)
                                  select new RelatorioModel
                                  {
                                      DescricaoProva = $"Ano: {provas.Ano} - Curso: {cursos.Nome} - Edição: {provas.Edicao}",
                                      DescricaoTipoProva = Helpers.GetEnumDescription((Enums.TipoDaProva)questoes.TipoProva),
                                      DescricaoDificuldadeQuestao = Helpers.GetEnumDescription((Enums.DificuldadeDaQuestao)questoes.DificuldadeQuestao),
                                      Enunciado = questoes.Enunciado,
                                      RespostaA = questoes.RespostaA,
                                      RespostaB = questoes.RespostaB,
                                      RespostaC = questoes.RespostaC,
                                      RespostaD = questoes.RespostaD,
                                      RespostaE = questoes.RespostaE,
                                      DescricaoRespostaCorreta = Helpers.GetEnumDescription((Enums.RespostaCerta)questoes.RespostaCorreta),
                                      RespostaDissertativa = questoes.RespostaDissertativa,
                                      QuestoesDisciplinas = string.Join(',', from questoesDisciplinas in _context.QuestoesDisciplinas.ToList()
                                                                             join disciplinas in _context.Disciplinas.ToList() on questoesDisciplinas.IdDisciplina equals disciplinas.Id
                                                                             where questoesDisciplinas.IdQuestao == questoes.Id
                                                                             select disciplinas.Descricao)
                                  }).ToList();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Dados");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Prova";
                worksheet.Cell(currentRow, 2).Value = "Tipo da Questão";
                worksheet.Cell(currentRow, 3).Value = "Dificuldade da Questão";
                worksheet.Cell(currentRow, 4).Value = "Enunciado";
                worksheet.Cell(currentRow, 5).Value = "Resposta A";
                worksheet.Cell(currentRow, 6).Value = "Resposta B";
                worksheet.Cell(currentRow, 7).Value = "Resposta C";
                worksheet.Cell(currentRow, 8).Value = "Resposta D";
                worksheet.Cell(currentRow, 9).Value = "Resposta E";
                worksheet.Cell(currentRow, 10).Value = "Resposta Múltipla Escolha";
                worksheet.Cell(currentRow, 11).Value = "Resposta Dissertativa";
                worksheet.Cell(currentRow, 12).Value = "Disciplinas";
                foreach (var item in dadosRelatorio)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.DescricaoProva;
                    worksheet.Cell(currentRow, 2).Value = item.DescricaoTipoProva;
                    worksheet.Cell(currentRow, 3).Value = item.DescricaoDificuldadeQuestao;
                    worksheet.Cell(currentRow, 4).Value = item.Enunciado;
                    worksheet.Cell(currentRow, 5).Value = item.RespostaA;
                    worksheet.Cell(currentRow, 6).Value = item.RespostaB;
                    worksheet.Cell(currentRow, 7).Value = item.RespostaC;
                    worksheet.Cell(currentRow, 8).Value = item.RespostaD;
                    worksheet.Cell(currentRow, 9).Value = item.RespostaE;
                    worksheet.Cell(currentRow, 10).Value = item.DescricaoRespostaCorreta;
                    worksheet.Cell(currentRow, 11).Value = item.RespostaDissertativa;
                    worksheet.Cell(currentRow, 12).Value = item.QuestoesDisciplinas;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "users.xlsx");
                }
            }
        }
    }
}
