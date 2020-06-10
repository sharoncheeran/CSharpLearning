using System;

namespace firstProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            double num1, num2;

            Console.Write("Num 1: ");
            num1 = Convert.ToDouble((Console.ReadLine());
            Console.Write("Num 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Answer: " + num1 / num2);
            Console.WriteLine("Input was: " + num1 + " and " + num2);
        }
    }
} 
