namespace Builder
{   
    // This is the Director - the guy who orders which cook what to cook
    public class Cashier
    {
        public void Make(ICook cook)
        {
            cook.AddSauce();
            cook.AddTopping();
        }
    }
}
