using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameAdminPanel.Data;
using GameAdminPanel.Models;

namespace GameAdminPanel.Controllers
{
    public class ErousController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ErousController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Erous
        public async Task<IActionResult> Index()
        {
            return View(await _context.Eroi.ToListAsync());
        }

        // GET: Erous/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var erou = await _context.Eroi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (erou == null)
            {
                return NotFound();
            }

            return View(erou);
        }

        // GET: Erous/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Erous/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nume,Clasa,Nivel")] Erou erou)
        {
            if (ModelState.IsValid)
            {
                _context.Add(erou);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(erou);
        }

        // GET: Erous/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var erou = await _context.Eroi.FindAsync(id);
            if (erou == null)
            {
                return NotFound();
            }
            return View(erou);
        }

        // POST: Erous/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nume,Clasa,Nivel")] Erou erou)
        {
            if (id != erou.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(erou);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ErouExists(erou.Id))
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
            return View(erou);
        }

        // GET: Erous/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var erou = await _context.Eroi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (erou == null)
            {
                return NotFound();
            }

            return View(erou);
        }

        // POST: Erous/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var erou = await _context.Eroi.FindAsync(id);
            if (erou != null)
            {
                _context.Eroi.Remove(erou);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ErouExists(int id)
        {
            return _context.Eroi.Any(e => e.Id == id);
        }
    }
}
