namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }

        public Pizza(string image, string name, string description, string price) 
        {
            this.Image = image;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
    }
}
