using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_pizzeria.Models;

namespace razor_pizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzasDB = new List<PizzasModel>()
        {
            new PizzasModel() {
                ImageTitle="Margherita",
                PizzaName="Margherita",
                BasePrice=3,
                TomatoSauce=true,
                Mozzarella=true,
                FinalPrice=5 },
            new PizzasModel() {
                ImageTitle="Bolognese",
                PizzaName="Bolognese",
                BasePrice=3,
                TomatoSauce=true,
                Mozzarella=true,
                Beef=true,
                FinalPrice=7.5f },
            new PizzasModel() {
                ImageTitle="Carbonara",
                PizzaName="Carbonara",
                BasePrice=3,
                TomatoSauce=true,
                Mozzarella=true,
                Bacon=true,
                Spices=true,
                FinalPrice=7.5f },
            new PizzasModel() {
                ImageTitle="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=3,
                TomatoSauce=true,
                Mozzarella=true,
                Pineapple=true,
                Ham=true,
                FinalPrice=6f },
            new PizzasModel() {
                ImageTitle="MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=3,
                TomatoSauce=true,
                Mozzarella=true,
                Bacon=true,
                Ham=true,
                Beef=true,
                FinalPrice=8f },
            new PizzasModel() {
                ImageTitle="Mushroom",
                PizzaName="Mushroom",
                BasePrice=3,
                TomatoSauce=true,
                Mozzarella=true,
                Mushroom=true,
                Ham=true,
                FinalPrice=6f },
            new PizzasModel() {
                ImageTitle="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=3,
                TomatoSauce=true,
                Mozzarella=true,
                Pepperoni=true,
                FinalPrice=7.5f },
        };

        public void OnGet()
        {
        }
    }
}
