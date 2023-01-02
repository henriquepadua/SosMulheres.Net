using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SosMulheres.Config;
using SosMulheres.Models;

namespace SosMulheres.Controllers
{
    public class RelatoController : Controller
    {
        private readonly SosMulheresContext _context;

        public RelatoController(SosMulheresContext context)
        {
            _context = context;
        }

        // GET: Relatos
        /*public async Task<IActionResult> Index()
        {
              return View(await _context.Relatos.ToListAsync());
        }

        // GET: Relatos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Relatos == null)
            {
                return NotFound();
            }

            var relatos = await _context.Relatos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (relatos == null)
            {
                return NotFound();
            }

            return View(relatos);
        }

        // GET: Relatos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Relatos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Relato")] Relatos relatos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(relatos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(relatos);
        }

        // GET: Relatos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Relatos == null)
            {
                return NotFound();
            }

            var relatos = await _context.Relatos.FindAsync(id);
            if (relatos == null)
            {
                return NotFound();
            }
            return View(relatos);
        }

        // POST: Relatos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Relato")] Relatos relatos)
        {
            if (id != relatos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(relatos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RelatosExists(relatos.Id))
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
            return View(relatos);
        }

        // GET: Relatos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Relatos == null)
            {
                return NotFound();
            }

            var relatos = await _context.Relatos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (relatos == null)
            {
                return NotFound();
            }

            return View(relatos);
        }

        // POST: Relatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Relatos == null)
            {
                return Problem("Entity set 'SosMulheresContext.Relatos'  is null.");
            }
            var relatos = await _context.Relatos.FindAsync(id);
            if (relatos != null)
            {
                _context.Relatos.Remove(relatos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RelatosExists(int id)
        {
          return _context.Relatos.Any(e => e.Id == id);
        }
        */
    }
}
