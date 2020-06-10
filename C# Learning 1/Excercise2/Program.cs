using System;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Divisible();
        }

        private static void Divisible()
        {
            var count = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(count++);
                }
            }
        }

        private static void UserInput()
        {
            var input = 0;

            do
            {
                Console.WriteLine("Number: ");
                input = Convert.ToInt32(Console.ReadLine());

            } while (true);
        }
    }
}
