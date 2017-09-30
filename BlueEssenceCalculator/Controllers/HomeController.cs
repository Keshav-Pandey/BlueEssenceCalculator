using BlueEssenceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlueEssenceCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This website is a utility to help you calculate the amount of blue essence you will get at the start of the new season.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Keshav Pandey";

            return View();
        }

        public ActionResult Chart()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(EssenceModel model) {
            if (ModelState.IsValid)
            {
                model.CalculateTotal();
                TempData["Total"] = model.Total;
                TempData["Skins"] = model.Skins;
            }
            else {
                TempData["Error"] = true;
            }
            return View();
        }
    }
}