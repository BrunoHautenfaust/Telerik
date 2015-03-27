
/*Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder
 and has the same functionality as Substring in the class String.*/

using System.Text;
namespace _01_StringBuilder.Substring
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            string mid = sb.ToString().Substring(index, length);
            StringBuilder result = new StringBuilder(mid);
            return result;
        }
    }
}
