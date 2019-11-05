using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assessment6b.Models;

namespace Assessment6b.Controllers
{
    public class HomeController : Controller
    {
        JellybeanDbContext db = new JellybeanDbContext();
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Jellybean()
        {
            List<JellyBean> jellybeans = db.JellyBean.ToList();

            return View(jellybeans);
        }

        public IActionResult CreateJelly(JellyBean u)
        {
            db.JellyBean.Add(u);
            db.SaveChanges();

            return RedirectToAction("JellyBean");
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
