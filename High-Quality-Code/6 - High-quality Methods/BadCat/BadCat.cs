namespace Task5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program   
    {
        static void Main(string[] args) // BGCoder Score 10/100
        {
            var list = new List<string>();

            int number = int.Parse(Console.ReadLine());

            while (number >= 1)
            {
                string text = Console.ReadLine();
                list.Add(text);
                number--;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < list.Count; i++)
            {
                string[] line = list[i].Split(' ').ToArray();
                int num1 = int.Parse(line[0]);
                int num2 = int.Parse(line[line.Length - 1]);

                if (line[2] == "before")
                {
                    sb.Append(num1).Append(num2);
                }
                else if (line[2] == "after")
                {
                    sb.Append(num2).Append(num1);
                }

            }
            Console.WriteLine(sb.ToString());




        }
    }
}