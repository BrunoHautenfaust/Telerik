namespace ChainOfResponsibility
{
    using System;

    public class Cashier : IHandler
    {
        public override void HandleRequest(int request)
        {
            if (request <= 1000)
            {
                Console.WriteLine(this + " handles the client request.");
            }
            else if (this.Successor != null)
            {
                this.Successor.HandleRequest(request);
            }
        }

        public override string ToString()
        {
            return "Cashier";
        }
    }
}
