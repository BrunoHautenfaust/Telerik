namespace Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GadgetFacade gf = new GadgetFacade();
            gf.GetBinoculars();
            gf.GetFlamethrower();
            gf.GetSprings();
        }
    }
}
