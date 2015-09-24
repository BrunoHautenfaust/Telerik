namespace Strategy
{
    using System;

    public class Taxi : AbstractTransport
    {
        public override void Transportation()
        {
            Console.WriteLine("Caught a taxi.");
        }
    }
}
