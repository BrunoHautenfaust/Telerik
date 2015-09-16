namespace Builder
{
   public class HawaiiCook : ICook
    {
        private Pizza pizza;

        public HawaiiCook()
        {
            this.pizza = new Pizza("Hawaii");
        }

        public void AddSauce()
        {
            this.pizza.Sauce = Sauce.Cream;
        }

        public void AddTopping()
        {
            this.pizza.Topping = Topping.pineapple;
        }

        public Pizza Pizza
        {
            get
            {
                return this.pizza;
            }
        }
    }
}
