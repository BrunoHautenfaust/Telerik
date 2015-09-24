namespace ChainOfResponsibility
{
    using System;

    public class Program
    {
        /* A client wishes to take a loan(1000). Another client wishes to take a loan(5000). 
           The bank policy allows the cashier to process a loan request up to 1000. 
           If it's more than 1000, then the manager has to take care of it. */
        public static void Main(string[] args)
        {
            int clientRequest1 = 1000;
            int clientRequest2 = 5000;
            Cashier c = new Cashier();
            Manager m = new Manager();
            c.SetSuccessor(m);
            c.HandleRequest(clientRequest1);
            c.HandleRequest(clientRequest2);
        }
    }
}
