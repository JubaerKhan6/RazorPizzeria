using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }

        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.HAM) PizzaPrice += 2;
            if (Pizza.Tuna) PizzaPrice += 3;
            if (Pizza.Sausage) PizzaPrice += 1;
            if (Pizza.Chicken) PizzaPrice += 4;
            if (Pizza.Beef) PizzaPrice += 10;
            if (Pizza.Mushroom) PizzaPrice += 2;
            if (Pizza.Pepperoni) PizzaPrice += 3;
            if (Pizza.Pineapple) PizzaPrice += 100;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName , PizzaPrice});



        }
    }
}
