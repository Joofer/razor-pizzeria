namespace razor_pizzeria.Models
{
    public class PizzasModel
    {
        #region general

        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 2;
        public float FinalPrice { get; set; }
        public bool MakeVegie { get; set; }

        #endregion

        #region ingredients

        public bool Pepperoni { get; set; }
        public bool Bacon { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }

        public bool Mozzarella { get; set; }
        public bool Cheddar { get; set; }

        public bool Jalapeno { get; set; }
        public bool Spices { get; set; }
        public bool Mushroom { get; set; }
        public bool Pineapple { get; set; }

        public bool TomatoSauce { get; set; }

        #endregion
    }
}
