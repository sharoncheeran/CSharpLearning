using System;

namespace CompositionInheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        /*public Vehicle()
        {
            Console.WriteLine("Vehicle ...");
        }*/

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle {0}", registrationNumber);
        }
    }
}