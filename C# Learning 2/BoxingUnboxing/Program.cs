using System;
using System.Collections;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);

            var number = (int) list[1];
        }
    }
}
