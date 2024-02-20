using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoEnade.Models;
using ProjetoEnade.Repository;
using ProjetoEnade.Utils;

namespace ProjetoEnade.Controllers
{
    public class QuestaoGabaritoController : Controller
    {
        private readonly EnadeDbContext _context;

        public QuestaoGabaritoController(EnadeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var teste = from questoes in _context.QuestaoGabarito.ToList()
                        select questoes;

            var enadeDbContext = from questoes in _context.QuestaoGabarito.ToList()
                                 join provas in _context.Provas.ToList() on questoes.IdProva equals provas.Id
                                 join curso in _context.Cursos.ToList() on provas.IdCurso equals curso.Id
                                 select new QuestaoGabarito
                                 {
                                     Id = questoes.Id,
                                     Enunciado = questoes.Enunciado,
                                     DescricaoTipoProva = Helpers.GetEnumDescription((Enums.TipoDaProva)questoes.TipoProva),
                                     DescricaoDificuldadeQuestao = Helpers.GetEnumDescription((Enums.DificuldadeDaQuestao)questoes.DificuldadeQuestao),
                                     DescricaoRespostaCorreta = Helpers.GetEnumDescription((Enums.RespostaCerta)questoes.RespostaCorreta),
                                     DescricaoProva = $"Ano: {provas.Ano} - Curso: {curso.Nome} - Edição: {provas.Edicao}"
                                 };

            return View(enadeDbContext.ToList());
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questaoGabarito = (from questoes in _context.QuestaoGabarito.ToList()
                                   join provas in _context.Provas.ToList() on questoes.IdProva equals provas.Id
                                   join curso in _context.Cursos.ToList() on provas.IdCurso equals curso.Id
                                   where questoes.Id == id
                                   select new QuestaoGabarito
                                   {
                                       Id = questoes.Id,
                                       Enunciado = questoes.Enunciado,
                                       DescricaoTipoProva = Helpers.GetEnumDescription((Enums.TipoDaProva)questoes.TipoProva),
                                       DescricaoDificuldadeQuestao = Helpers.GetEnumDescription((Enums.DificuldadeDaQuestao)questoes.DificuldadeQuestao),
                                       DescricaoRespostaCorreta = Helpers.GetEnumDescription((Enums.RespostaCerta)questoes.RespostaCorreta),
                                       DescricaoProva = $"Ano: {provas.Ano} - Curso: {curso.Nome} - Edição: {provas.Edicao}",
                                       RespostaA = questoes.RespostaA,
                                       RespostaB = questoes.RespostaB,
                                       RespostaC = questoes.RespostaC,
                                       RespostaD = questoes.RespostaD,
                                       RespostaE = questoes.RespostaE,
                                       EnunciadoImage = questoes.EnunciadoImage,
                                       EnunciadoImageBase64 = questoes.EnunciadoImage != null ? Convert.ToBase64String(questoes.EnunciadoImage) : null,
                                       RespostaAImage = questoes.RespostaAImage,
                                       RespostaAImageBase64 = questoes.RespostaAImage != null ? Convert.ToBase64String(questoes.RespostaAImage) : null,
                                       RespostaBImage = questoes.RespostaBImage,
                                       RespostaBImageBase64 = questoes.RespostaBImage != null ? Convert.ToBase64String(questoes.RespostaBImage) : null,
                                       RespostaCImage = questoes.RespostaCImage,
                                       RespostaCImageBase64 = questoes.RespostaCImage != null ? Convert.ToBase64String(questoes.RespostaCImage) : null,
                                       RespostaDImage = questoes.RespostaDImage,
                                       RespostaDImageBase64 = questoes.RespostaDImage != null ? Convert.ToBase64String(questoes.RespostaDImage) : null,
                                       RespostaEImage = questoes.RespostaEImage,
                                       RespostaEImageBase64 = questoes.RespostaEImage != null ? Convert.ToBase64String(questoes.RespostaEImage) : null,
                                       RespostaDissertativa = questoes.RespostaDissertativa,
                                       DescricaoDisciplinas = string.Join(',', from questoesDisciplinas in _context.QuestoesDisciplinas.ToList()
                                                                               join disciplinas in _context.Disciplinas.ToList() on questoesDisciplinas.IdDisciplina equals disciplinas.Id
                                                                               where questoesDisciplinas.IdQuestao == questoes.Id
                                                                               select disciplinas.Nome)

                                   }).FirstOrDefault();


            if (questaoGabarito == null)
            {
                return NotFound();
            }

            string enunciadoImageDataURL = string.Format("data:image/jpg;base64,{0}", questaoGabarito.EnunciadoImageBase64);
            string respostaAImageDataURL = string.Format("data:image/jpg;base64,{0}", questaoGabarito.RespostaAImageBase64);
            string respostaBImageDataURL = string.Format("data:image/jpg;base64,{0}", questaoGabarito.RespostaBImageBase64);
            string respostaCImageDataURL = string.Format("data:image/jpg;base64,{0}", questaoGabarito.RespostaCImageBase64);
            string respostaDImageDataURL = string.Format("data:image/jpg;base64,{0}", questaoGabarito.RespostaDImageBase64);
            string respostaEImageDataURL = string.Format("data:image/jpg;base64,{0}", questaoGabarito.RespostaEImageBase64);

            ViewData["EnunciadoImageDataURL"] = enunciadoImageDataURL;
            ViewData["RespostaAImageDataURL"] = respostaAImageDataURL;
            ViewData["RespostaBImageDataURL"] = respostaBImageDataURL;
            ViewData["RespostaCImageDataURL"] = respostaCImageDataURL;
            ViewData["RespostaDImageDataURL"] = respostaDImageDataURL;
            ViewData["RespostaEImageDataURL"] = respostaEImageDataURL;

            return View(questaoGabarito);
        }

        public IActionResult Create()
        {
            var provas = from prova in _context.Provas.ToList()
                         join curso in _context.Cursos.ToList() on prova.IdCurso equals curso.Id
                         select new
                         {
                             Id = prova.Id,
                             DescricaoCompleta = $"Ano: {prova.Ano} - Curso: {curso.Nome} - Edição: {prova.Edicao}"
                         };

            var disciplinas = from disciplina in _context.Disciplinas.ToList()
                              select new
                              {
                                  disciplina.Id,
                                  DescricaoDisciplina = disciplina.Descricao
                              };

            ViewData["DetalhesProva"] = new SelectList(provas, "Id", "DescricaoCompleta", null);
            ViewData["Disciplinas"] = new SelectList(disciplinas, "Id", "DescricaoDisciplina", null);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(QuestaoGabarito questaoGabarito)
        {
            if (ModelState.IsValid)
            {

                foreach (var file in Request.Form.Files)
                {
                    MemoryStream ms = new();
                    file.CopyTo(ms);

                    switch (file.Name)
                    {
                        case "enunciadoImage":
                            questaoGabarito.EnunciadoImage = ms.ToArray();
                            break;
                        case "respostaAImage":
                            questaoGabarito.RespostaAImage = ms.ToArray();
                            break;
                        case "respostaBImage":
                            questaoGabarito.RespostaBImage = ms.ToArray();
                            break;
                        case "respostaCImage":
                            questaoGabarito.RespostaCImage = ms.ToArray();
                            break;
                        case "respostaDImage":
                            questaoGabarito.RespostaDImage = ms.ToArray();
                            break;
                        default:
                            questaoGabarito.RespostaEImage = ms.ToArray();
                            break;
                    }


                    ms.Close();
                    ms.Dispose();
                }

                _context.Add(questaoGabarito);
                await _context.SaveChangesAsync();

                foreach (var item in questaoGabarito.MultiDisciplinas)
                {
                    var questoesDisciplinas = new QuestoesDisciplinas { IdDisciplina = item, IdQuestao = questaoGabarito.Id };

                    _context.Add(questoesDisciplinas);
                }

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            ViewData["IdProva"] = new SelectList(_context.Provas, "Id", "Id", questaoGabarito.IdProva);
            return View(questaoGabarito);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var questaoGabarito = (from questoes in _context.QuestaoGabarito.ToList()
                                   join provas in _context.Provas.ToList() on questoes.IdProva equals provas.Id
                                   join curso in _context.Cursos.ToList() on provas.IdCurso equals curso.Id
                                   where questoes.Id == id
                                   select new QuestaoGabarito
                                   {
                                       Id = questoes.Id,
                                       Enunciado = questoes.Enunciado,
                                       TipoProva = questoes.TipoProva,
                                       DescricaoTipoProva = Helpers.GetEnumDescription((Enums.TipoDaProva)questoes.TipoProva),
                                       DificuldadeQuestao = questoes.DificuldadeQuestao,
                                       DescricaoDificuldadeQuestao = Helpers.GetEnumDescription((Enums.DificuldadeDaQuestao)questoes.DificuldadeQuestao),
                                       RespostaCorreta = questoes.RespostaCorreta,
                                       DescricaoRespostaCorreta = Helpers.GetEnumDescription((Enums.RespostaCerta)questoes.RespostaCorreta),
                                       DescricaoProva = $"Ano: {provas.Ano} - Curso: {curso.Nome} - Edição: {provas.Edicao}",
                                       RespostaA = questoes.RespostaA,
                                       RespostaB = questoes.RespostaB,
                                       RespostaC = questoes.RespostaC,
                                       RespostaD = questoes.RespostaD,
                                       RespostaE = questoes.RespostaE,
                                       RespostaDissertativa = questoes.RespostaDissertativa,
                                       MultiDisciplinas = (from questoesDisciplinas in _context.QuestoesDisciplinas.ToList()
                                                           join disciplinas in _context.Disciplinas.ToList() on questoesDisciplinas.IdDisciplina equals disciplinas.Id
                                                           where questoesDisciplinas.IdQuestao == questoes.Id
                                                           select questoesDisciplinas.IdDisciplina).ToList()
                                   }).FirstOrDefault();

            var provasCursos = from prova in _context.Provas.ToList()
                               join curso in _context.Cursos.ToList() on prova.IdCurso equals curso.Id
                               select new
                               {
                                   Id = prova.Id,
                                   DescricaoCompleta = $"Ano: {prova.Ano} - Curso: {curso.Nome} - Edição: {prova.Edicao}"
                               };

            var disciplinas = from disciplina in _context.Disciplinas.ToList()
                              select new
                              {
                                  disciplina.Id,
                                  DescricaoDisciplina = disciplina.Descricao
                              };            

            if (questaoGabarito == null)
            {
                return NotFound();
            }
            
            ViewData["DetalhesProva"] = new SelectList(provasCursos, "Id", "DescricaoCompleta", null);
            ViewData["Disciplinas"] = new SelectList(disciplinas, "Id", "DescricaoDisciplina", null);

            return View(questaoGabarito);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, QuestaoGabarito questaoGabarito)
        {
            if (id != questaoGabarito.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    foreach (var file in Request.Form.Files)
                    {
                        MemoryStream ms = new();
                        file.CopyTo(ms);

                        switch (file.Name)
                        {
                            case "enunciadoImage":
                                questaoGabarito.EnunciadoImage = ms.ToArray();
                                break;
                            case "respostaAImage":
                                questaoGabarito.RespostaAImage = ms.ToArray();
                                break;
                            case "respostaBImage":
                                questaoGabarito.RespostaBImage = ms.ToArray();
                                break;
                            case "respostaCImage":
                                questaoGabarito.RespostaCImage = ms.ToArray();
                                break;
                            case "respostaDImage":
                                questaoGabarito.RespostaDImage = ms.ToArray();
                                break;
                            default:
                                questaoGabarito.RespostaEImage = ms.ToArray();
                                break;
                        }

                        ms.Close();
                        ms.Dispose();
                    }

                    _context.Update(questaoGabarito);
                    await _context.SaveChangesAsync();

                    if (questaoGabarito.MultiDisciplinas.Any())
                    {
                        var questoesDisciplinasParaExcluir = _context.QuestoesDisciplinas.Where(x => x.IdQuestao == questaoGabarito.Id);
                        _context.RemoveRange(questoesDisciplinasParaExcluir);

                        foreach (var item in questaoGabarito.MultiDisciplinas)
                        {
                            var questoesDisciplinas = new QuestoesDisciplinas { IdDisciplina = item, IdQuestao = questaoGabarito.Id };

                            _context.Add(questoesDisciplinas);
                        }

                        await _context.SaveChangesAsync();
                    }

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestaoGabaritoExists(questaoGabarito.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
             
            var teste = ModelState.Select(x => x.Value.Errors)
                           .Where(y => y.Count > 0)
                           .ToList();

            var provas = from prova in _context.Provas.ToList()
                         join curso in _context.Cursos.ToList() on prova.IdCurso equals curso.Id
                         select new
                         {
                             Id = prova.Id,
                             DescricaoCompleta = $"Ano: {prova.Ano} - Curso: {curso.Nome} - Edição: {prova.Edicao}"
                         };

            ViewData["DetalhesProva"] = new SelectList(provas, "Id", "DescricaoCompleta", null);
            return View(questaoGabarito);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questaoGabarito = (from questoes in _context.QuestaoGabarito.ToList()
                                   join provas in _context.Provas.ToList() on questoes.IdProva equals provas.Id
                                   join curso in _context.Cursos.ToList() on provas.IdCurso equals curso.Id
                                   where questoes.Id == id
                                   select new QuestaoGabarito
                                   {
                                       Id = questoes.Id,
                                       Enunciado = questoes.Enunciado,
                                       DescricaoTipoProva = Helpers.GetEnumDescription((Enums.TipoDaProva)questoes.TipoProva),
                                       DescricaoDificuldadeQuestao = Helpers.GetEnumDescription((Enums.DificuldadeDaQuestao)questoes.DificuldadeQuestao),
                                       DescricaoRespostaCorreta = Helpers.GetEnumDescription((Enums.RespostaCerta)questoes.RespostaCorreta),
                                       DescricaoProva = $"Ano: {provas.Ano} - Curso: {curso.Nome} - Edição: {provas.Edicao}",
                                       RespostaA = questoes.RespostaA,
                                       RespostaB = questoes.RespostaB,
                                       RespostaC = questoes.RespostaC,
                                       RespostaD = questoes.RespostaD,
                                       RespostaE = questoes.RespostaE,
                                       EnunciadoImage = questoes.EnunciadoImage,
                                       EnunciadoImageBase64 = questoes.EnunciadoImage != null ? Convert.ToBase64String(questoes.EnunciadoImage) : null,
                                       RespostaAImage = questoes.RespostaAImage,
                                       RespostaAImageBase64 = questoes.RespostaAImage != null ? Convert.ToBase64String(questoes.RespostaAImage) : null,
                                       RespostaBImage = questoes.RespostaBImage,
                                       RespostaBImageBase64 = questoes.RespostaBImage != null ? Convert.ToBase64String(questoes.RespostaBImage) : null,
                                       RespostaCImage = questoes.RespostaCImage,
                                       RespostaCImageBase64 = questoes.RespostaCImage != null ? Convert.ToBase64String(questoes.RespostaCImage) : null,
                                       RespostaDImage = questoes.RespostaDImage,
                                       RespostaDImageBase64 = questoes.RespostaDImage != null ? Convert.ToBase64String(questoes.RespostaDImage) : null,
                                       RespostaEImage = questoes.RespostaEImage,
                                       RespostaEImageBase64 = questoes.RespostaEImage != null ? Convert.ToBase64String(questoes.RespostaEImage) : null,
                                       RespostaDissertativa = questoes.RespostaDissertativa,
                                       DescricaoDisciplinas = string.Join(',', from questoesDisciplinas in _context.QuestoesDisciplinas.ToList()
                                                                               join disciplinas in _context.Disciplinas.ToList() on questoesDisciplinas.IdDisciplina equals disciplinas.Id
                                                                               where questoesDisciplinas.IdQuestao == questoes.Id
                                                                               select disciplinas.Nome)

                                   }).FirstOrDefault();

            if (questaoGabarito == null)
            {
                return NotFound();
            }

            string enunciadoImageDataURL = string.Format("data:image/jpg;base64,{0}", questaoGabarito.EnunciadoImageBase64);
            string respostaAImageDataURL = string.Format("data:image/jpg;base64,{0}", questaoGabarito.RespostaAImageBase64);
            string respostaBImageDataURL = string.Format("data:image/jpg;base64,{0}", questaoGabarito.RespostaBImageBase64);
            string respostaCImageDataURL = string.Format("data:image/jpg;base64,{0}", questaoGabarito.RespostaCImageBase64);
            string respostaDImageDataURL = string.Format("data:image/jpg;base64,{0}", questaoGabarito.RespostaDImageBase64);
            string respostaEImageDataURL = string.Format("data:image/jpg;base64,{0}", questaoGabarito.RespostaEImageBase64);

            ViewData["EnunciadoImageDataURL"] = enunciadoImageDataURL;
            ViewData["RespostaAImageDataURL"] = respostaAImageDataURL;
            ViewData["RespostaBImageDataURL"] = respostaBImageDataURL;
            ViewData["RespostaCImageDataURL"] = respostaCImageDataURL;
            ViewData["RespostaDImageDataURL"] = respostaDImageDataURL;
            ViewData["RespostaEImageDataURL"] = respostaEImageDataURL;

            return View(questaoGabarito);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questaoGabarito = await _context.QuestaoGabarito.FindAsync(id);
            _context.QuestaoGabarito.Remove(questaoGabarito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestaoGabaritoExists(int id)
        {
            return _context.QuestaoGabarito.Any(e => e.Id == id);
        }
    }
}
