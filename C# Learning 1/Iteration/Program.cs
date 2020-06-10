using System;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoops();
            //ForEach();
            //DoWhile();
            RandomNumberClass();
        }

        private static void ForLoops()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (int i = 0; i >= 10; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void ForEach()
        {
            var name = "John Smith";
            var numbers = new int[] {1, 2, 3, 4};

            /*for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]); 
            }*/

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void DoWhile()
        {
            var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }

            while (true)
            {
                Console.Write("Name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Echo " + input);
                    continue;
                }

                break;
            }
        }

        private static void RandomNumberClass()
        {
            var random = new Random();

            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next()); //generates random numbers
                Console.WriteLine(random.Next(1, 10)); //generates random numbers between 2 ranges
            }*/
            const int passLength = 10;
            var buffer = new char[passLength];

            for (int i = 0; i < passLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26)); //generates random numbers between 2 ranges
            } 

            var pass = new string(buffer);

            Console.WriteLine(pass);
        }
    }
}
