namespace Task2
{
    using System;
    public class ProgramTEST
    {
        public static void Main(string[] args)
        {
            CookingClass cookingClass = new CookingClass();
            cookingClass.Cooking();

            Console.WriteLine("\n");

            Bool.CheckIfShouldVisitCell();
        }
    }
}
