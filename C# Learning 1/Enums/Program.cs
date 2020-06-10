using System;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); //casting to integer

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); //casting to the enum itself

            Console.WriteLine(method.ToString()); //converting the enum to string

            var method2 = "Express";
            var ship = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), method2); //parsing a string to enum
        }
    }
}
