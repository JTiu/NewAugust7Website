using Amazon.SimpleSystemsManagement.Model;
using August7thWebsite.Data;
using August7thWebsite.Models;
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

namespace August7thWebsite.Controllers
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

        

       

       




       
    }   
}
