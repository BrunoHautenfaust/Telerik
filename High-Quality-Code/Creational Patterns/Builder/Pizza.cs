namespace Builder
{
    using System;

    // This is the Product
    public class Pizza
    {
        private string name;
        private Topping topping;
        private Sauce sauce;

        public Pizza(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Topping Topping
        {
            get { return this.topping; }
            set { this.topping = value; }
        }

        public Sauce Sauce
        {
            get { return this.sauce; }
            set { this.sauce = value; }
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\t Topping: {1}\t Sauce: {2}", this.Name, this.Topping, this.Sauce);
        }
    }
}
