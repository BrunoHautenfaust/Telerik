namespace Strategy
{
    using System;

    public class Bus : AbstractTransport
    {
        public override void Transportation()
        {
            Console.WriteLine("Caught a bus.");
        }
    }
}
