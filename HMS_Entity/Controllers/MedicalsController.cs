using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HMS_Entity;
using HMS_Entity.Models;

namespace HMS_Entity.Controllers
{
    public class MedicalsController : Controller
    {
        private readonly HospitalDBContext _context;

        public MedicalsController(HospitalDBContext context)
        {
            _context = context;
        }

        // GET: Medicals
        public async Task<IActionResult> Index()
        {
            return View(await _context.Medical.ToListAsync());
        }

        // GET: Medical/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medical = await _context.Medical
                .FirstOrDefaultAsync(m => m.mId == id);
            if (medical == null)
            {
                return NotFound();
            }

            return View(medical);
        }

        // GET: Medical/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Medical/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mId,mName,mLocation,mSpecial")] Medical medical)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medical);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medical);
        }

        // GET: Medical/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medical = await _context.Medical.FindAsync(id);
            if (medical == null)
            {
                return NotFound();
            }
            return View(medical);
        }

        // POST: Medical/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("mId,mName,mLocation,mSpecial")] Medical medical)
        {
            if (id != medical.mId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medical);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicalExists(medical.mId))
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
            return View(medical);
        }

        // GET: Medical/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medical = await _context.Medical
                .FirstOrDefaultAsync(m => m.mId == id);
            if (medical == null)
            {
                return NotFound();
            }

            return View(medical);
        }

        // POST: Medical/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medical = await _context.Medical.FindAsync(id);
            if (medical != null)
            {
                _context.Medical.Remove(medical);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicalExists(int id)
        {
            return _context.Medical.Any(e => e.mId == id);
        }
    }
}
