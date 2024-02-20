using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoEnade.Models;
using ProjetoEnade.Repository;

namespace ProjetoEnade.Controllers
{
    public class DisciplinasController : Controller
    {
        private readonly EnadeDbContext _context;

        public DisciplinasController(EnadeDbContext context)
        {
            _context = context;
        }

        // GET: Disciplinas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Disciplinas.ToListAsync());
        }

        // GET: Disciplinas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disciplinas = await _context.Disciplinas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (disciplinas == null)
            {
                return NotFound();
            }

            return View(disciplinas);
        }

        // GET: Disciplinas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Disciplinas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Descricao,Id")] Disciplinas disciplinas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(disciplinas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(disciplinas);
        }

        // GET: Disciplinas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disciplinas = await _context.Disciplinas.FindAsync(id);
            if (disciplinas == null)
            {
                return NotFound();
            }
            return View(disciplinas);
        }

        // POST: Disciplinas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nome,Descricao,Id")] Disciplinas disciplinas)
        {
            if (id != disciplinas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(disciplinas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DisciplinasExists(disciplinas.Id))
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
            return View(disciplinas);
        }

        // GET: Disciplinas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disciplinas = await _context.Disciplinas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (disciplinas == null)
            {
                return NotFound();
            }

            return View(disciplinas);
        }

        // POST: Disciplinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var disciplinas = await _context.Disciplinas.FindAsync(id);
            _context.Disciplinas.Remove(disciplinas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DisciplinasExists(int id)
        {
            return _context.Disciplinas.Any(e => e.Id == id);
        }
    }
}
