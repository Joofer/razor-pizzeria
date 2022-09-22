using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pizzeria.Models;

namespace razor_pizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float Price { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Price = Pizza.BasePrice;

            if (Pizza.Pepperoni) Price += 2;
            if (Pizza.Bacon) Price += 2;
            if (Pizza.Ham) Price += 2;
            if (Pizza.Beef) Price += 2;
            if (Pizza.Mozzarella) Price += 1.5f;
            if (Pizza.Cheddar) Price += 1.5f;
            if (Pizza.Jalapeno) Price += 1;
            if (Pizza.Spices) Price += 1;
            if (Pizza.Mushroom) Price += 1.5f;
            if (Pizza.Pineapple) Price += 1;
            if (Pizza.TomatoSauce) Price += 1;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, Price });
        }
    }
}
