using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using What2Eat.Models;

namespace What2Eat.Controllers
{
    public class TodoListeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TodoListe()
        {
            List<TodoListeModel> punkte = new List<TodoListeModel>();

            punkte.Add(new TodoListeModel { OffenePunkte = "• Wochenplanung als Highlights auf der Startseite" });
            punkte.Add(new TodoListeModel { OffenePunkte = "• Liste mit Mahlzeiten und bool(mag ich) für jeden Mitesser" });
            punkte.Add(new TodoListeModel { OffenePunkte = "• Randomizer für den fall wenn man nicht weiß worauf man lust hat" });
            punkte.Add(new TodoListeModel { OffenePunkte = "• Bewertungsseite für jede Person" });
            punkte.Add(new TodoListeModel { OffenePunkte = "• Persönliche Logins für jeden Mitesser" });
            punkte.Add(new TodoListeModel { OffenePunkte = "• Details- Seite für jede Mahlzeit (never ending story)" });
            punkte.Add(new TodoListeModel { OffenePunkte = "• (Details) Rezept" });
            punkte.Add(new TodoListeModel { OffenePunkte = "• (Details) Zutaten" });
            punkte.Add(new TodoListeModel { OffenePunkte = "• (Details) Inhaltsstoffe" });
            punkte.Add(new TodoListeModel { OffenePunkte = "• User kann Haushalte erstellen und andere User zu diesen einladen" });

            return View(punkte);
        }
    }
}
