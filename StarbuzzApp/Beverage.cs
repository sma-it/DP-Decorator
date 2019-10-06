using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzApp
{
    abstract class Beverage : IResource
    {
        string description;
        public string Description => description;

        public Beverage(string description)
        {
            this.description = description;
        }

        public abstract float Cost();

        public void PrintReceipt()
        {
            Console.WriteLine(Description + "\t" + Cost());
        }
    }
}
