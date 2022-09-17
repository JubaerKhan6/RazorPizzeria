using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita", PizzaName="Margerita", BasePrice=5, Cheese=true, Pepperoni=true },
            new PizzasModel(){ImageTitle="Carbonara", PizzaName="Carbonara", BasePrice=2, Mushroom=true, HAM=true },
            new PizzasModel(){ImageTitle="Hawaiian", PizzaName="Hawaiian", BasePrice=3, Sausage=true, Cheese=true },
            new PizzasModel(){ImageTitle="MeatFeast", PizzaName="MeatFeast", BasePrice=5, Chicken=true, Beef=true, Sausage=true },
            new PizzasModel(){ImageTitle="Mushroom", PizzaName="Mushroom", BasePrice=5, Mushroom=true, Pepperoni=true },
            new PizzasModel(){ImageTitle="Seafood", PizzaName="Seafood", BasePrice=5, Tuna=true, Cheese=true },
            new PizzasModel(){ImageTitle="Bolognese", PizzaName="Bolognese", BasePrice=5, Mushroom=true, Pepperoni=true },
            new PizzasModel(){ImageTitle="FourSeasons", PizzaName="FourSeasons",BasePrice=4, Mushroom=true, Pepperoni=true , Chicken=true, Beef=true},
            new PizzasModel(){ImageTitle="CheeseBlast", PizzaName="CheeseBlast", BasePrice=3, Cheese=true, Pepperoni=true, Mushroom=true},
        };

        public void OnGet()
        {
        }
    }
}
