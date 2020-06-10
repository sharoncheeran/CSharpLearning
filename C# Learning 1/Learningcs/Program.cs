using System;

namespace Learningcs
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new int[3];
            number[0] = 1;

            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);

            var names = new string[3] { "Jack", "John", "Mary" };

            var firstName = "Sharon";
            var lastname = "Cheeran";

            var fullName = firstName + lastname;
            var myFullName = string.Format("Name is {0} {1}", firstName, lastname);

            var names1 = new string[3] { "Jack", "John", "Mary" };
            var combine = string.Join(", ", names1);
            Console.WriteLine(combine);

            var text = @"Hi bro
                        new line bro
                        c:\nn\nnzznn\nn"; //the '@' makes a difference
            Console.WriteLine(text);
        }
    }
}
