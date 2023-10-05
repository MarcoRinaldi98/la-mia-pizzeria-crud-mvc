namespace la_mia_pizzeria_static.Models.Database_Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<Pizza> Pizze { get; set; }

        public Ingredient()
        {

        }
    }
}
