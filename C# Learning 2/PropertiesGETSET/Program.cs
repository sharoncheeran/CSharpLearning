using System;

namespace PropertiesGETSET
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1998, 11, 17)); ;
            Console.WriteLine(person.Age());
        }
    }
}
