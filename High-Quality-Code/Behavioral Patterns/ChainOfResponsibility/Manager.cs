namespace ChainOfResponsibility
{
    using System;

    public class Manager : IHandler
    {
        public override void HandleRequest(int request)
        {
            if (request <= 5000)
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
            return "Manager";
        }
    }
}
