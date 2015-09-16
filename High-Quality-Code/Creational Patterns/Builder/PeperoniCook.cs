namespace Builder
{
    // Concrete ICook:
    public class PeperoniCook : ICook
    {
        private Pizza pizza;

        public PeperoniCook()
        {
            this.pizza = new Pizza("Peperoni");
        }
        
        public void AddSauce()
        {
            this.pizza.Sauce = Sauce.Tomato;
        }

        public void AddTopping()
        {
            this.pizza.Topping = Topping.mozzarella;
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
