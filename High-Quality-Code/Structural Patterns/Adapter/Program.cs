namespace Adapter
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            ITarget adapter = new USPlug();
            adapter.ChangePlugExtension();
        }
    }
}
