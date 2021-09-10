using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using What2Eat.Models;

namespace What2Eat.Controllers
{
    public class EssenslisteController : Controller
    {
        public string Suchwert { get; private set; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Suche()
        {
            Suchwert = new EssenslisteModel().Suchwert;

            return View(Suchwert);
        }

        public ActionResult Essensliste()
        {
            List<EssenslisteModel> mahlzeiten = new List<EssenslisteModel>();
            mahlzeiten.Add(new EssenslisteModel { Id = 1, Name = "Croque", Janic = true, Oma = true, Opa = true });
            mahlzeiten.Add(new EssenslisteModel { Id = 2, Name = "Burger", Janic = true, Oma = true, Opa = true });
            mahlzeiten.Add(new EssenslisteModel { Id = 3, Name = "Chinesisch", Janic = false, Oma = true, Opa = true });

            return View(mahlzeiten);
        }
    }
}
