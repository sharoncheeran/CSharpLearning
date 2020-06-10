using System;

namespace Methods
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse("abc");
            var result = int.TryParse("abc", out num);

            if (result)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Coversion failed");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
            Console.WriteLine(calculator.Add(new int[] { 5, 5, 5, 8, 8 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point location {0}, {1}", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point location {0}, {1}", point.X, point.Y);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error occured");
            }
        }
    }
}
