using System.ComponentModel.DataAnnotations;

namespace RazorPizzeria.Models
{
    public class PizzasModel
    {
        [Key]
        public int Id { get; set; }
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }

        public float BasePrice { get; set; } = 2;
        public bool Cheese { get; set; }
        public bool Pepperoni { get; set; }

        public bool Pineapple { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool Chicken { get; set; }

        public bool Beef { get; set; }
        public bool HAM { get; set; }
        public bool Sausage { get; set; }



    }
}
