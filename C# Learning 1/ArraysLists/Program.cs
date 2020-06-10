using System;
using System.Collections.Generic;

namespace ArraysLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays();
            Lists();
        }
        private static void Arrays()
        {
            var numbers = new[] {11, 28, 3, 4, 5, 1};
            //Length of the array
            Console.WriteLine("Length of array: " + numbers.Length);
            //IndexOf the array for a value]
            var index = Array.IndexOf(numbers, 4);
            Console.WriteLine("Position of number: " + index);
            //Clear array
            Array.Clear(numbers, 0, 2);

            foreach (var num in numbers)
            {
                Console.WriteLine("After clearing: " + num);
            }

            //Copying to another array
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            foreach (var num in another)
            {
                Console.WriteLine("After duplicating: " + num);
            }

            //Sorting numbers from asc
            Array.Sort(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine("Sorting array asc: " + number);
            }

            //Sorting numbers from desc
            Array.Reverse(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine("Sorting array desc: " + number);
            }
        }

        private static void Lists()
        {
            var numbers = new List<int>() {1, 2, 3, 4};
            numbers.Add(1);
            numbers.AddRange(new int[3] {5, 6, 7});

            foreach (var VARIABLE in numbers)
            {
                Console.WriteLine(VARIABLE);
            }

            //Index of 1 in list
            Console.WriteLine("Index of 1: "+ numbers.IndexOf(1));
            Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);

            //Removing numbers from list
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var VARIABLE in numbers)
            {
                Console.WriteLine(VARIABLE);
            }

            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
