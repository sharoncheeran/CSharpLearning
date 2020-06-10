using System;
using Classes.Math;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.firstName = "Sharon";
            john.lastName = "Cheeran";
            john.Introduce();

            var Calc = new Calculator();
            Console.WriteLine(Calc.add(5, 6)); 
        }
    }
}
