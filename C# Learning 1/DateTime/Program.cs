using System;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateT();
            TS();
        }

        private static void DateT()
        {
            var dateTime = new System.DateTime(2020, 1, 1);
            var now = System.DateTime.Now;
            var today = System.DateTime.Today;

            Console.WriteLine("hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }

        private static void TS()
        {
            //Creating Time Span    
            var ts = new TimeSpan(1, 2, 3);

            var ts1 = new TimeSpan(1, 0, 0);
            var ts2 = TimeSpan.FromHours(1);

            var start = System.DateTime.Now;
            var end = System.DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine(duration);

            //Properties
            Console.WriteLine("Minutes: " + ts.Minutes);
            Console.WriteLine("Total Minutes: " + ts.TotalMinutes);

            //Add
            Console.WriteLine("Add: " + ts.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract: " + ts.Subtract(TimeSpan.FromMinutes(2)));
            
            //Coversion to string
            Console.WriteLine("To string: " + ts.ToString());

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}

