using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader reader = new StreamReader(new MemoryStream());
            /*ArrayList list= new ArrayList();
            list.Add(1);
            list.Add("Sharon");
            list.Add(new Text());

            var anotherList = new List<Shape>();*/

            Shape shape = new Text();
            Text text = (Text) shape;
        }
    }
}
