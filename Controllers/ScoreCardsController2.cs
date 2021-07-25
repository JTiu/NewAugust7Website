using August7thWebsite.Data;
using August7thWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace August7thWebsiteVS.Controllers
{
    public class ScoreCardsController2 : Controller
    {
        private readonly ApplicationDbContext _context;
        public ScoreCardsController2(ApplicationDbContext context)
        {
            _context = context;
        }
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
    }
}
