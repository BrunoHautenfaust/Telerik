using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Attributes
{
    [Attributes(2, 11)]
    class AttributesTEST
    {
        static void Main(string[] args)
        {
            Type type = typeof(AttributesTEST);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (Attributes attr in allAttributes)
            {
                Console.WriteLine(
                  "This class version is {0}", attr);
            }

        }
    }
}
