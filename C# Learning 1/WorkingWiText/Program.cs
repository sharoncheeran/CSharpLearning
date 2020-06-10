using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWiText
{
    class Program
    {
        static void Main(string[] args)
        {
            //Str();
            //var sentence = "This is going to be a really really really really really long text";
            //Console.WriteLine(StringUtility.SummarisingTxt(sentence)); 
            StringBuilder();
        }

        private static void Str()
        {
            var fullName = "Sharon Cheeran ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim()); //Trims any spaces
            Console.WriteLine("Upper: '{0}'", fullName.ToUpper().Trim()); //Trims any spaces

            var index = fullName.IndexOf(' '); //splitting via indexOf
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FN: " + firstName);
            Console.WriteLine("LN: " + lastName);

            var names = fullName.Split(' '); //splitting it and storing in the array 
            Console.WriteLine("FN: " + names[0]);
            Console.WriteLine("LN: " + names[1]);

            Console.WriteLine(fullName.Replace("Sharon", "Joseph")); //replacing string

            if (String.IsNullOrWhiteSpace(" ")) //String null input check
            {
                Console.WriteLine("Invalid");
            }

            var str = "25"; //String conversion 
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f; //String conversion
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));
        }

        private static void StringBuilder()
        {
            var builder = new StringBuilder("Hello world");

            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First character: " + builder[0]);
        }
    }
}
