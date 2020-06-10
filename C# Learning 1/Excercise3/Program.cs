using System;

namespace Excercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Number1();
        }

        private static void Number1()
        {
            var sha = "";
            var arr = new char[] {};
            var arr2 = new char[] {};
            Console.WriteLine("Enter name: ");
            sha = Console.ReadLine();
            arr = sha.ToCharArray();
            arr2 = Array.Reverse(arr);
        }
    }
}
