using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using August7thWebsite.Data;
using August7thWebsite.Models;
using AutoMapper;
using August7thWebsiteVS.Models;
using System.IO;

namespace August7thWebsiteVS.Controllers
{
    public class ParticipantsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public ParticipantsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: Participants
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Participants;
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Participants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participant = await _context.Participants
                
                .FirstOrDefaultAsync(m => m.Id == id);
            if (participant == null)
            {
                return NotFound();
            }
            var base64 = Convert.ToBase64String(participant.ParticipantPhoto);
            ViewData["ParticipantUploadPhoto"] = $"data:image;base64,{base64}";
            return View(participant);
        }

        // GET: Participants/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Participants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,First_Name,Last_Name,Ring_Name,Weight,Wins,Losses,Draw,KnockOuts,PictureParticipant")] ParticipantViewModel participantViewModel)
        {
            if (ModelState.IsValid)
            {
                MemoryStream memoryStream = new MemoryStream();
                participantViewModel.PictureParticipant.CopyTo(memoryStream);
                participantViewModel.ParticipantPhoto = memoryStream.ToArray();
                _context.Add(participantViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
          //  ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", participant.Id);
            return View(participantViewModel);
        }

        // GET: Participants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participant = await _context.Participants.FindAsync(id);
            if (participant == null)
            {
                return NotFound();
            }
            //ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", participant.IdentityUserId);
            ParticipantViewModel participantViewModel = _mapper.Map<ParticipantViewModel>(participant);
            return View(participantViewModel);
        }

        // POST: Participants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,First_Name,Last_Name,Ring_Name,Weight,Wins,Losses,Draw,KnockOuts,PictureParticipant")] ParticipantViewModel participantViewModel)
        {
            if (id != participantViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    MemoryStream memoryStream = new MemoryStream();
                    participantViewModel.PictureParticipant.CopyTo(memoryStream);
                    participantViewModel.ParticipantPhoto = memoryStream.ToArray();
                    _context.Update(participantViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParticipantExists(participantViewModel.Id))
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
            //ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", participant.IdentityUserId);
            return View(participantViewModel);
        }

        // GET: Participants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participant = await _context.Participants
                
                .FirstOrDefaultAsync(m => m.Id == id);
            if (participant == null)
            {
                return NotFound();
            }

            return View(participant);
        }

        // POST: Participants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var participant = await _context.Participants.FindAsync(id);
            _context.Participants.Remove(participant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParticipantExists(int id)
        {
            return _context.Participants.Any(e => e.Id == id);
        }
    }
}
