using System;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("Result")]
        public IActionResult Result(string Name, string Location, string FavLanguage, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.FavLanguage = FavLanguage;
            ViewBag.Comment = Comment;
            return View();
        }
    }
}