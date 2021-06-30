using Amazon.SimpleSystemsManagement.Model;
using Box_Themis_Capstone.Data;
using Box_Themis_Capstone.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
//using System.Net.Http.Headers;

namespace Box_Themis_Capstone.Controllers
{
    public class HomeController : Controller
    {
        //added this
        private ApplicationDbContext _context;
        private ILogger<HomeController> _logger;

        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }
        
       public IActionResult Index()
        {
            
            return View();//wherevever i put the code above, the page will return the json response <playlist>
        }

        public IActionResult Privacy(int id)
        {
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://www.w3schools.com/cs/cs_user_input.asp");
            //// Add an Accept header for JSON format.
            //client.DefaultRequestHeaders.Accept.Add(
            //new MediaTypeWithQualityHeaderValue("application/json"));
            //// List data response.
            //HttpResponseMessage response = client.GetAsync("?api_key=DYNUporKDsTc9ZGGLtuFCWyqLqUgm3qWe0Fj").Result;
            //Console.WriteLine("this is where");
            var client = new RestClient("https://api.zoom.us/v2/users?status=active&page_size=30&page_number=1"); 
            var request = new RestRequest(Method.GET);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOm51bGwsImlzcyI6IjRESGhCVnFNVE82YlMxZVRrMDFvYlEiLCJleHAiOjE2MTgwOTU3NTAsImlhdCI6MTYxODAwOTM1MH0.xiVwoljucvx81-qNGjvwCdPDs9gZiFteUsOIjG9xNb4");
            //insert my own token here, right after bearer


            IRestResponse response = client.Execute(request);
            
            switch (id)
            {
                case 1:
                    ViewBag.Url = "https://www.youtube.com/embed/IATUT2qzDmU";
                    ViewBag.FightId = 1;
                    break;
                case 2: 
                    ViewBag.Url = "https://www.youtube.com/embed/5n6rBEYGNvQ";
                    ViewBag.FightId = 2;
                    break;
                case 3:
                    ViewBag.Url = "https://www.youtube.com/embed/YpOV57hEkkI";
                    ViewBag.FightId = 3;
                    break;
            }
            int StatusCode = (int)response.StatusCode;
            ViewData["Zoom"] = StatusCode;
            //Debug.WriteLine("My debug string here");//addedlast minute, returns test to the view output console
            Debug.WriteLine(response.Content);
            return View();
        }
        //this is the sandbox

        //public IActionResult Zoom(int id)
        //{
            
        //    //var client = new RestClient("https://api.zoom.us/v2/users?status=active&page_size=30&page_number=1");
        //    //var request = new RestRequest(Method.GET);
        //    //request.AddHeader("content-type", "application/json");
        //    //request.AddHeader("authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOm51bGwsImlzcyI6IjRESGhCVnFNVE82YlMxZVRrMDFvYlEiLCJleHAiOjE2MTgwOTU3NTAsImlhdCI6MTYxODAwOTM1MH0.xiVwoljucvx81-qNGjvwCdPDs9gZiFteUsOIjG9xNb4");
        //    //insert my own token here, right after bearer


        //    //IRestResponse response = client.Execute(request);

            
        //    //var StatusCode = response.Content;
        //    //ViewData["Zoom"] = StatusCode;
        //    ////Debug.WriteLine("My debug string here");//addedlast minute, returns test to the view output console
        //    //Debug.WriteLine(response.Content);
        //    //return View();
        //    //this was a temporary patch do determine functionality, did get an '200' call
        //}


        //this is the end
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult About(int id)
        {

            List<ScoreCard> theScores = _context.ScoreCards.ToList();
            var score = _context.ScoreCards.Where(s => s.ScoreCardId == id).Single();
            //not really here, but a search method       
            //ViewData["Message"] = score;
            return View(score);

        }

        public IActionResult Training()
        {
            ViewData["message"] = "";
            ViewData["myJudgeName"] = "";
            ViewData["Title"] = "";
            return View();//training
        }

        public IActionResult BoxingMatchDialog()
        {
            //ViewData["message"] = "Welcome to the BoxThemis Interactive Judging Training Exercise"
            ViewData["Line_1"] = "";
            ViewData["myJudgeName"] = "";
            ViewData["Title"] = "";
            return View();//
        }
        public IActionResult Submit()
        {
            //Console.WriteLine(Request);
            //Console.WriteLine(Request.Form["B1Score"]);
            Console.ReadLine();
            return View();
        }
        public IActionResult PickFight()
        {
            return View();

        }

        [HttpPost]
        public IActionResult PickFight(SearchRequest searchRequest)
        {
            string url = $"https://youtube.googleapis.com/youtube/v3/search?part=snippet&maxResults=25&q={searchRequest.Keyword}&key=AIzaSyCUx0W6QcVtK0pZ8V3tAYCmRnt9W3F0b-M";
            var client = new HttpClient();
            var response = client.GetAsync(url);
            if (response.Result.IsSuccessStatusCode)
            {
                var jsonResponse = response.Result.Content.ReadAsStringAsync().Result;                //Process information
                var searchResult = JsonConvert.DeserializeObject<SearchResult>(jsonResponse);
                List<string> videoSrcs = searchResult.items.Select(i => "https://www.youtube.com/embed/" + i.id.videoId + "?}autohide=1&autoplay =1").ToList();
                ViewBag.videoSrcs = videoSrcs;
            }
            return View();
        }

        [HttpPost]
        public IActionResult PickFightPage_Schedule_Zoom()
        {
            string url = $"https://api.zoom.us/v2/users/zoomkey2021@gmail.com/meetings";
            var client = new HttpClient();
            var zoomMeetingRequest = new ZoomMeetingRequest
            {
                topic = "this is jt",
                type = 1

            };

            var jsonRequest = JsonConvert.SerializeObject(zoomMeetingRequest);
            var httpContent = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOm51bGwsImlzcyI6IkhOd3hidnZ1UjZtSGhhOW5iM3dpbXciLCJleHAiOjE2MTg3MDMwOTcsImlhdCI6MTYxODA5ODI5N30.wuhghpD9SsOgd5rLNASrZIg0AKlCacgKnNxshiRz7U0");
            var response = client.PostAsync(url, httpContent);
            if (response.Result.IsSuccessStatusCode)
            {
                var jsonResponse = response.Result.Content.ReadAsStringAsync().Result;                //Process information
                var zoomMeetingResponse = JsonConvert.DeserializeObject<ZoomMeetingResponse>(jsonResponse);
              
                TempData["Start"] = zoomMeetingResponse.start_url;
                TempData["Join"] = zoomMeetingResponse.start_url;
            }
            return RedirectToAction("Privacy");
        }

        //private ApplicationDbContext db = new ApplicationDbContext();
        //private EmpApplicationContext db3 = new EmpApplicationContext();
        [HttpPost]
        [ValidateAntiForgeryToken]

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
                return RedirectToAction(nameof(About), new { id = sid});//need to get the ID
                //return RedirectToAction(nameof(BoxingMatchDialog));
                //return RedirectToAction(nameof(About));
            }
            catch
            {
                return View();
            }




        }
    }   
}
