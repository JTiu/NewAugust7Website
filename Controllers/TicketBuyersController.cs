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
    public class TicketBuyersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TicketBuyersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TicketBuyers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.TicketBuyers.Include(t => t.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: TicketBuyers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketBuyer = await _context.TicketBuyers
                .Include(t => t.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ticketBuyer == null)
            {
                return NotFound();
            }

            return View(ticketBuyer);
        }

        // GET: TicketBuyers/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: TicketBuyers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,First_Name,Last_Name,Email,CellPhone,IdentityUserId")] TicketBuyer ticketBuyer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ticketBuyer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", ticketBuyer.IdentityUserId);
            return View(ticketBuyer);
        }

        // GET: TicketBuyers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketBuyer = await _context.TicketBuyers.FindAsync(id);
            if (ticketBuyer == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", ticketBuyer.IdentityUserId);
            return View(ticketBuyer);
        }

        // POST: TicketBuyers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,First_Name,Last_Name,Email,CellPhone,IdentityUserId")] TicketBuyer ticketBuyer)
        {
            if (id != ticketBuyer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ticketBuyer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketBuyerExists(ticketBuyer.Id))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", ticketBuyer.IdentityUserId);
            return View(ticketBuyer);
        }

        // GET: TicketBuyers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketBuyer = await _context.TicketBuyers
                .Include(t => t.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ticketBuyer == null)
            {
                return NotFound();
            }

            return View(ticketBuyer);
        }

        // POST: TicketBuyers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticketBuyer = await _context.TicketBuyers.FindAsync(id);
            _context.TicketBuyers.Remove(ticketBuyer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketBuyerExists(int id)
        {
            return _context.TicketBuyers.Any(e => e.Id == id);
        }
    }
}
