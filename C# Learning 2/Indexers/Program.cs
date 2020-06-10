using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Sharon";
            Console.WriteLine(cookie["name"]);
        }
    }
}
