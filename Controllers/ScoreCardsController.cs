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
    public class ScoreCardsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScoreCardsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ScoreCards
        public async Task<IActionResult> Index()
        {
            return View(await _context.ScoreCards.ToListAsync());
        }

        // GET: ScoreCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scoreCard = await _context.ScoreCards
                .FirstOrDefaultAsync(m => m.ScoreCardId == id);
            if (scoreCard == null)
            {
                return NotFound();
            }

            return View(scoreCard);
        }

        // GET: ScoreCards/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ScoreCard newScoreCard)
        {
            try
            {
                int total_B1 = 0;
                int total_B2 = 0;

                total_B1 += newScoreCard.Round_1_B1;//here to work  Round_1_B2
                total_B2 += newScoreCard.Round_1_B2;//here to work
                total_B1 += newScoreCard.Round_2_B1;
                total_B2 += newScoreCard.Round_2_B2;
                total_B1 += newScoreCard.Round_3_B1;
                total_B2 += newScoreCard.Round_3_B2;
                total_B1 += newScoreCard.Round_4_B1;
                total_B2 += newScoreCard.Round_4_B2;
                total_B1 += newScoreCard.Round_5_B1;
                total_B2 += newScoreCard.Round_5_B2;
                total_B1 += newScoreCard.Round_6_B1;
                total_B2 += newScoreCard.Round_6_B2;
                total_B1 += newScoreCard.Round_7_B1;
                total_B2 += newScoreCard.Round_7_B2;
                total_B1 += newScoreCard.Round_8_B1;
                total_B2 += newScoreCard.Round_8_B2;
                total_B1 += newScoreCard.Round_9_B1;
                total_B2 += newScoreCard.Round_9_B2;
                total_B1 += newScoreCard.Round_10_B1;
                total_B2 += newScoreCard.Round_10_B2;
                total_B1 += newScoreCard.Round_11_B1;
                total_B2 += newScoreCard.Round_11_B2;
                total_B1 += newScoreCard.Round_12_B1;
                total_B2 += newScoreCard.Round_12_B2;

                newScoreCard.Total_B1 = total_B1;
                newScoreCard.Total_B2 = total_B2;

                _context.ScoreCards.Add(newScoreCard);
                _context.SaveChanges();
                int sid = newScoreCard.ScoreCardId;
                return RedirectToAction(nameof(Finished), new { id = sid });//need to get the ID
                //return RedirectToAction(nameof(BoxingMatchDialog));
                //return RedirectToAction(nameof(CreateScorecard));
            }
            catch
            {
                return View();
            }

        }
        public IActionResult Finished(int id)
        {
            List<ScoreCard> theScores = _context.ScoreCards.ToList();
            var score = _context.ScoreCards.Where(s => s.ScoreCardId == id).Single();

            return View(score);
        }

        // GET: ScoreCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scoreCard = await _context.ScoreCards.FindAsync(id);
            if (scoreCard == null)
            {
                return NotFound();
            }
            return View(scoreCard);
        }

        // POST: ScoreCards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ScoreCardId,FightId,UserId,Round_1_B1,Round_1_B2,Round_2_B1,Round_2_B2,Round_3_B1,Round_3_B2,Round_4_B1,Round_4_B2,Round_5_B1,Round_5_B2,Round_6_B1,Round_6_B2,Round_7_B1,Round_7_B2,Round_8_B1,Round_8_B2,Round_9_B1,Round_9_B2,Round_10_B1,Round_10_B2,Round_11_B1,Round_11_B2,Round_12_B1,Round_12_B2,Total_B1,Total_B2,DeterminateFactor_R1,DeterminateFactor_R2,DeterminateFactor_R3,DeterminateFactor_R4,DeterminateFactor_R5,DeterminateFactor_R6,DeterminateFactor_R7,DeterminateFactor_R8,DeterminateFactor_R9,DeterminateFactor_R10,DeterminateFactor_R11,DeterminateFactor_R12,FirstNameOnCard,LastNameOnCard,DateCreated,Boxer1,Boxer2")] ScoreCard scoreCard)
        {
            if (id != scoreCard.ScoreCardId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scoreCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScoreCardExists(scoreCard.ScoreCardId))
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
            return View(scoreCard);
        }

        // GET: ScoreCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scoreCard = await _context.ScoreCards
                .FirstOrDefaultAsync(m => m.ScoreCardId == id);
            if (scoreCard == null)
            {
                return NotFound();
            }

            return View(scoreCard);
        }

        // POST: ScoreCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scoreCard = await _context.ScoreCards.FindAsync(id);
            _context.ScoreCards.Remove(scoreCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScoreCardExists(int id)
        {
            return _context.ScoreCards.Any(e => e.ScoreCardId == id);
        }
    }
}
