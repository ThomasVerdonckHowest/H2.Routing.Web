using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using H2.Routing.Web.Models;

namespace H2.Routing.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Home/ShowID/{id?}")]
        public IActionResult ShowId(int id)
        {
            return Content($"You wanted id: {id}");
        }
        [Route("Home/Search/{id?}")]
        public IActionResult SearchById(int id)
        {
            return Content($"You searched for product id {id}");
        }
        [Route("Home/Search/{needle?}")]
        public IActionResult SearchByProductName(string needle)
        {
            return Content($"You searched for product name {needle}");
        }
        [Route("/Home/ShowUserInfo/{id?}/{username?}")]
        public IActionResult ShowUserInfo(int id, string username)
        {
            return Content($"Userid:{id}, username:{username}");
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
