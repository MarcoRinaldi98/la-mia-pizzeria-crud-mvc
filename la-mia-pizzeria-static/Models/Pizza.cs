using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        [MaxLength(500)]
        public string Image { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }

        public Pizza()
        {
            
        }

        public Pizza(string image, string name, string description, string price) 
        {
            this.Image = image;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
    }
}
