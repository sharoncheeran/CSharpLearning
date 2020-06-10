﻿using System;

namespace ClassCoupling
{
    public class PresentationObject
    {
        public int  Width { get; set; }
        public int  Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object duplicated");
        }
    }
}