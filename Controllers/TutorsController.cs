using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestSalarySystem.Data;
using TestSalarySystem.Models;

namespace TestSalarySystem.Controllers
{
    public class TutorsController : Controller
    {
        private readonly SalaryContext _context;

        public TutorsController(SalaryContext context)
        {
            _context = context;
        }

        // GET: Tutors
        public async Task<IActionResult> Index()
        {
              return _context.Tutors != null ? 
                          View(await _context.Tutors.ToListAsync()) :
                          Problem("Entity set 'SalaryContext.Tutors'  is null.");
        }

        // GET: Tutors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Tutors == null)
            {
                return NotFound();
            }

            var tutor = await _context.Tutors
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tutor == null)
            {
                return NotFound();
            }

            return View(tutor);
        }

        // GET: Tutors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tutors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,IC,Contact,Password,Gender,Status")] Tutor tutor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tutor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tutor);
        }

        // GET: Tutors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Tutors == null)
            {
                return NotFound();
            }

            var tutor = await _context.Tutors.FindAsync(id);
            if (tutor == null)
            {
                return NotFound();
            }
            return View(tutor);
        }

        // POST: Tutors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,IC,Contact,Password,Gender,Status")] Tutor tutor)
        {
            if (id != tutor.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tutor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TutorExists(tutor.ID))
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
            return View(tutor);
        }

        // GET: Tutors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Tutors == null)
            {
                return NotFound();
            }

            var tutor = await _context.Tutors
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tutor == null)
            {
                return NotFound();
            }

            return View(tutor);
        }

        // POST: Tutors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Tutors == null)
            {
                return Problem("Entity set 'SalaryContext.Tutors'  is null.");
            }
            var tutor = await _context.Tutors.FindAsync(id);
            if (tutor != null)
            {
                _context.Tutors.Remove(tutor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TutorExists(int id)
        {
          return (_context.Tutors?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
