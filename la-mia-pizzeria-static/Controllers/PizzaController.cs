using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_static.Models;
using la_mia_pizzeria_static.Database;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using la_mia_pizzeria_static.CustomLoggers;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        private ICustomLogger _myLogger;
        private PizzaContext _myDatabase;

        public PizzaController(PizzaContext db, ICustomLogger logger)
        {
            _myLogger = logger;
            _myDatabase = db;
        }

        public IActionResult Index()
        {
            _myLogger.WriteLog("L'utente è arrivato sulla pagina Pizza > Index");

            List<Pizza> pizze = _myDatabase.Pizze.ToList<Pizza>();

            return View(pizze);
        }

        public IActionResult Details(int id)
        {
            _myLogger.WriteLog("L'utente è arrivato sulla pagina Pizza > Details");

            Pizza? foundedPizza = _myDatabase.Pizze.Where(Article => Article.Id == id).FirstOrDefault();

            if (foundedPizza == null)
            {
                return NotFound($"La pizza {id} non è stata trovata!");
            }
            else
            {
                return View("Details", foundedPizza);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            _myLogger.WriteLog("L'utente è arrivato sulla pagina Pizza > Create");

            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza newPizza)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", newPizza);
            }

            _myDatabase.Pizze.Add(newPizza);
            _myDatabase.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Pizza? pizzaToEdit = _myDatabase.Pizze.Where(pizza => pizza.Id == id).FirstOrDefault();

            if (pizzaToEdit == null)
            {
                return NotFound("La pizza che vuoi modificare non è stata trovata");
            }
            else
            {
                _myLogger.WriteLog("L'utente è arrivato sulla pagina Pizza > Update");

                return View("Update", pizzaToEdit);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Pizza modifiedPizza)
        {
            if (!ModelState.IsValid)
            {
                return View("Update", modifiedPizza);
            }

            Pizza? pizzaToUpdate = _myDatabase.Pizze.Find(id);

            if (pizzaToUpdate != null)
            {
                EntityEntry<Pizza> entryEntity = _myDatabase.Entry(pizzaToUpdate);
                entryEntity.CurrentValues.SetValues(modifiedPizza);

                _myDatabase.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return NotFound("Mi dispiace non è stata trovata la pizza da aggiornare");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            Pizza? pizzaToDelete = _myDatabase.Pizze.Where(pizza => pizza.Id == id).FirstOrDefault();

            if (pizzaToDelete != null)
            {
                _myDatabase.Pizze.Remove(pizzaToDelete);
                _myDatabase.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return NotFound("La pizza da eliminare non è stata trovata!");
            }
        }
    }
}
