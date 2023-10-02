using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_static.Models;
using la_mia_pizzeria_static.Database;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            using (PizzaContext db = new PizzaContext())
            {
                List<Pizza> pizze = db.Pizze.ToList<Pizza>();

                return View(pizze);
            }
        }

        public IActionResult Details(int id)
        {
            using (PizzaContext db = new PizzaContext())
            {
                Pizza? foundedPizza = db.Pizze.Where(Article => Article.Id == id).FirstOrDefault();

                if (foundedPizza == null)
                {
                    return NotFound($"La pizza {id} non è stata trovata!");
                }
                else
                {
                    return View("Details", foundedPizza);
                }
            }
        }

        public IActionResult UtenteIndex()
        {
            using (PizzaContext db = new PizzaContext())
            {
                List<Pizza> pizze = db.Pizze.ToList<Pizza>();

                return View(pizze);
            }
        }
    }
}
