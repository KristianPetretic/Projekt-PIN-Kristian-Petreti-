using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekt_Kristian.Data;
using Test_Kiki.Models;

namespace Projekt_Kristian.Controllers
{
    public class NarudžbaController : Controller
    {
        private readonly Projekt_KristianContext _context;

        public NarudžbaController(Projekt_KristianContext context)
        {
            _context = context;
        }

        // GET: Narudžba
        public async Task<IActionResult> Index()
        {
            return View(await _context.Narudžba.ToListAsync());
        }

        // GET: Narudžba/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var narudžba = await _context.Narudžba
                .FirstOrDefaultAsync(m => m.Id == id);
            if (narudžba == null)
            {
                return NotFound();
            }

            return View(narudžba);
        }

        // GET: Narudžba/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Narudžba/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Proizvod_Id,Količina,Narudžba_Id")] Narudžba narudžba)
        {
            if (ModelState.IsValid)
            {
                _context.Add(narudžba);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(narudžba);
        }

        // GET: Narudžba/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var narudžba = await _context.Narudžba.FindAsync(id);
            if (narudžba == null)
            {
                return NotFound();
            }
            return View(narudžba);
        }

        // POST: Narudžba/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Proizvod_Id,Količina,Narudžba_Id")] Narudžba narudžba)
        {
            if (id != narudžba.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(narudžba);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NarudžbaExists(narudžba.Id))
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
            return View(narudžba);
        }

        // GET: Narudžba/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var narudžba = await _context.Narudžba
                .FirstOrDefaultAsync(m => m.Id == id);
            if (narudžba == null)
            {
                return NotFound();
            }

            return View(narudžba);
        }

        // POST: Narudžba/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var narudžba = await _context.Narudžba.FindAsync(id);
            _context.Narudžba.Remove(narudžba);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NarudžbaExists(int id)
        {
            return _context.Narudžba.Any(e => e.Id == id);
        }
    }
}
