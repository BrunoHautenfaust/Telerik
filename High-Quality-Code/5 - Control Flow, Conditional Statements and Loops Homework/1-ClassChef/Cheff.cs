namespace HQ_Code5
{
    using System;
    public class Chef
    {
        private Bowl GetBowl()
        {
            return new Bowl(); 
        }
        private Potato GetPotato()
        {
            return new Potato();
        }
        private Carrot GetCarrot()
        {
            return new Carrot();
        }
        private void Cut(Vegetable vegetable)
        {
            Console.WriteLine("{0} is cut.", vegetable);
        }
        private void Peel(Vegetable vegetable)
        {
            Console.WriteLine("{0} is peeled.", vegetable);
        }

        
        public void Cook()
        {
            Bowl bowl = new Bowl(); 
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            this.GetBowl();

            Peel(potato);
            Peel(carrot);

            Cut(potato);
            Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }
        
    }
}