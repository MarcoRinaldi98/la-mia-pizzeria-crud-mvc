using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Pizza> pizze = new List<Pizza>();

            Pizza pizzaMargherita = new Pizza(
                "margherita.jpg",
                "Pizza Margherita",
                "La pizza Margherita è la tipica pizza napoletana, condita con pomodoro, mozzarella, basilico fresco, sale e olio;",
                "€ 8,00"
            );

            Pizza pizzaMarinara = new Pizza(
                "marinara.jpg",
                "Pizza Marinara",
                "La pizza alla marinara è una tipica pizza napoletana condita con pomodoro, aglio, origano e olio.",
                "€ 9,00"
            );

            Pizza pizzaFormaggi = new Pizza(
                "formaggi.jpg",
                "Pizza Quattro Formaggi",
                "La pizza ai quattro formaggi nella cucina italiana è una varietà di pizza, che viene condita con quattro tipi di formaggio.",
                "€ 9,00"
            );

            Pizza pizzaDiavola = new Pizza(
                "diavola.jpg",
                "Pizza Diavola",
                "La pizza alla diavola si prepara unendo a pomodoro e mozzarella il salamino a fette, l'origano e un filo d'olio.",
                "€ 8,00"
            );

            Pizza pizzaCapricciosa = new Pizza(
                "capricciosa.jpg",
                "Pizza Capricciosa",
                "La pizza capricciosa è una pizza tipica della cucina italiana caratterizzata da un condimento di pomodoro, mozzarella, prosciutto cotto (o spesso anche crudo), funghi (di solito champignon), olive verdi e nere, e carciofini e spesso uova.",
                "€ 10,00"
            );

            Pizza pizzaBoscaiola = new Pizza(
                "boscaiola.jpg",
                "Pizza Boscaiola",
                "La pizza boscaiola è davvero gustosa caratterizzata da funghi champignon accompagnati da gustosi pezzetti di salsiccia e ricoperta infine da mozzarella.",
                "€ 10,00"
            );

            Pizza pizzaAmericana = new Pizza(
                "americana.jpg",
                "Pizza Americana",
                "La pizza würstel e patatine è un'invenzione italiana ispirata ai cibi americani, accontenta sia a grandi che piccini per la sua semplicità",
                "€ 12,00"
            );

            pizze.Add(pizzaMargherita);
            pizze.Add(pizzaMarinara);
            pizze.Add(pizzaFormaggi);
            pizze.Add(pizzaDiavola);
            pizze.Add(pizzaCapricciosa);
            pizze.Add(pizzaBoscaiola);
            pizze.Add(pizzaAmericana);

            return View(pizze);
        }

        public IActionResult UtenteIndex()
        {
            List<Pizza> pizze = new List<Pizza>();

            Pizza pizzaMargherita = new Pizza(
                "margherita.jpg",
                "Pizza Margherita",
                "La pizza Margherita è la tipica pizza napoletana, condita con pomodoro, mozzarella, basilico fresco, sale e olio;",
                "€ 8,00"
            );

            Pizza pizzaMarinara = new Pizza(
                "marinara.jpg",
                "Pizza Marinara",
                "La pizza alla marinara è una tipica pizza napoletana condita con pomodoro, aglio, origano e olio.",
                "€ 9,00"
            );

            Pizza pizzaFormaggi = new Pizza(
                "formaggi.jpg",
                "Pizza Quattro Formaggi",
                "La pizza ai quattro formaggi nella cucina italiana è una varietà di pizza, che viene condita con quattro tipi di formaggio.",
                "€ 9,00"
            );

            Pizza pizzaDiavola = new Pizza(
                "diavola.jpg",
                "Pizza Diavola",
                "La pizza alla diavola si prepara unendo a pomodoro e mozzarella il salamino a fette, l'origano e un filo d'olio.",
                "€ 8,00"
            );

            Pizza pizzaCapricciosa = new Pizza(
                "capricciosa.jpg",
                "Pizza Capricciosa",
                "La pizza capricciosa è una pizza tipica della cucina italiana caratterizzata da un condimento di pomodoro, mozzarella, prosciutto cotto (o spesso anche crudo), funghi (di solito champignon), olive verdi e nere, e carciofini e spesso uova.",
                "€ 10,00"
            );

            Pizza pizzaBoscaiola = new Pizza(
                "boscaiola.jpg",
                "Pizza Boscaiola",
                "La pizza boscaiola è davvero gustosa caratterizzata da funghi champignon accompagnati da gustosi pezzetti di salsiccia e ricoperta infine da mozzarella.",
                "€ 10,00"
            );

            Pizza pizzaAmericana = new Pizza(
                "americana.jpg",
                "Pizza Americana",
                "La pizza würstel e patatine è un'invenzione italiana ispirata ai cibi americani, accontenta sia a grandi che piccini per la sua semplicità",
                "€ 12,00"
            );

            pizze.Add(pizzaMargherita);
            pizze.Add(pizzaMarinara);
            pizze.Add(pizzaFormaggi);
            pizze.Add(pizzaDiavola);
            pizze.Add(pizzaCapricciosa);
            pizze.Add(pizzaBoscaiola);
            pizze.Add(pizzaAmericana);

            return View(pizze);
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