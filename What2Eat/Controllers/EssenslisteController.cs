using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using What2Eat.Models;

namespace What2Eat.Controllers
{
    public class EssenslisteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Essensliste()
        {
            List<EssenslisteModel> mahlzeiten = new List<EssenslisteModel>();
            mahlzeiten.Add(new EssenslisteModel { Id = 1, Name = "Croque", Janic = true, Oma = true, Opa = true });
            mahlzeiten.Add(new EssenslisteModel { Id = 2, Name = "Burger", Janic = true, Oma = true, Opa = true });
            mahlzeiten.Add(new EssenslisteModel { Id = 3, Name = "Chinesisch", Janic = true, Oma = true, Opa = true });

            return View(mahlzeiten);
        }
    }
}
