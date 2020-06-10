﻿using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int ID;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.ID = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            
        }
    }
}