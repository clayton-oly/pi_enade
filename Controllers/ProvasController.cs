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
    public class ProvasController : Controller
    {
        private readonly EnadeDbContext _context;

        public ProvasController(EnadeDbContext context)
        {
            _context = context;
        }

        // GET: Provas
        public async Task<IActionResult> Index()
        {
            var enadeDbContext = _context.Provas.Include(p => p.Cursos);
            return View(await enadeDbContext.ToListAsync());
        }

        // GET: Provas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var provas = await _context.Provas
                .Include(p => p.Cursos)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (provas == null)
            {
                return NotFound();
            }

            return View(provas);
        }

        // GET: Provas/Create
        public IActionResult Create()
        {
            ViewData["Cursos"] = new SelectList(_context.Cursos, "Id", "Nome");
            return View();
        }

        // POST: Provas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCurso,Ano,Edicao,Id")] Provas provas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(provas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id"] = new SelectList(_context.Cursos, "Id", "Id", provas.Id);
            return View(provas);
        }

        // GET: Provas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var provas = await _context.Provas.FindAsync(id);
            if (provas == null)
            {
                return NotFound();
            }
            ViewData["Id"] = new SelectList(_context.Cursos, "Id", "Id", provas.Id);
            return View(provas);
        }

        // POST: Provas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCurso,Ano,Edicao,Id")] Provas provas)
        {
            if (id != provas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(provas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProvasExists(provas.Id))
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
            ViewData["Id"] = new SelectList(_context.Cursos, "Id", "Id", provas.Id);
            return View(provas);
        }

        // GET: Provas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var provas = await _context.Provas
                .Include(p => p.Cursos)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (provas == null)
            {
                return NotFound();
            }

            return View(provas);
        }

        // POST: Provas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var provas = await _context.Provas.FindAsync(id);
            _context.Provas.Remove(provas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProvasExists(int id)
        {
            return _context.Provas.Any(e => e.Id == id);
        }
    }
}
