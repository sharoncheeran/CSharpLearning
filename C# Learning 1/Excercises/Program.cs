using System;
using System.Linq;

namespace Excercises
{
    class Program
    {
        static void Main(string[] args)
        { 
            //rangeValue();
            //maxNum();
            //Image();
           SpeedCamera();
        }

        private static void rangeValue() //Function for 1st Exercise
        {

            var input = 0;

            Console.WriteLine("Enter a number: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input >= 1 && input <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        private static void maxNum()
        {
            int[] input1 = new int[2];

            Console.WriteLine("Write number 1: ");
            input1 = new[] {Convert.ToInt32(Console.ReadLine())};

            Console.WriteLine("Write number 2: ");
            input1 = new[] {Convert.ToInt32(Console.ReadLine())};
            
            Console.WriteLine(input1.Max());
        }

        private static void Image()
        {
            var height = 0;
            var width = 0;

            Console.WriteLine("Enter height: ");
            height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            width = Convert.ToInt32(Console.ReadLine());

            if (height > width)
            {
                Console.WriteLine("Portrait");
            }
            else if (height < width)
            {
                Console.WriteLine("Landscape");
            }
            else
            {
                Console.WriteLine("Square");
            }
        }

        private static void SpeedCamera()
        {
            var speedLimit = 0;
            var speedCar = 0;

            Console.WriteLine("Enter speed limit: ");
            speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter car speed: ");
            speedCar = Convert.ToInt32(Console.ReadLine());

            if (speedCar <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var result = speedCar - speedLimit;
                result = result / 5;

                Console.WriteLine(result);

                if (result > 12)
                {
                    Console.WriteLine("LS");
                }
            }
        }
    }

}
