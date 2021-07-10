using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using August7thWebsite.Data;
using August7thWebsite.Models;

namespace August7thWebsiteVS.Controllers
{
    public class LineUpsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LineUpsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LineUps
        public async Task<IActionResult> Index()
        {
            return View(await _context.LineUps.ToListAsync());
        }

        // GET: LineUps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lineUp = await _context.LineUps
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lineUp == null)
            {
                return NotFound();
            }

            return View(lineUp);
        }

        // GET: LineUps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LineUps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,Match_1_B1,Match_1_B2,Match_2_B1,Match_2_B2,Match_3_B1,Match_3_B2,Match_4_B1,Match_4_B2,Match_5_B1,Match_5_B2,Match_6_B1,Match_6_B2,Match_7_B1,Match_7_B2")] LineUp lineUp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lineUp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lineUp);
        }

        // GET: LineUps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lineUp = await _context.LineUps.FindAsync(id);
            if (lineUp == null)
            {
                return NotFound();
            }
            return View(lineUp);
        }

        // POST: LineUps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Match_1_B1,Match_1_B2,Match_2_B1,Match_2_B2,Match_3_B1,Match_3_B2,Match_4_B1,Match_4_B2,Match_5_B1,Match_5_B2,Match_6_B1,Match_6_B2,Match_7_B1,Match_7_B2")] LineUp lineUp)
        {
            if (id != lineUp.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lineUp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LineUpExists(lineUp.Id))
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
            return View(lineUp);
        }

        // GET: LineUps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lineUp = await _context.LineUps
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lineUp == null)
            {
                return NotFound();
            }

            return View(lineUp);
        }

        // POST: LineUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lineUp = await _context.LineUps.FindAsync(id);
            _context.LineUps.Remove(lineUp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LineUpExists(int id)
        {
            return _context.LineUps.Any(e => e.Id == id);
        }
    }
}
