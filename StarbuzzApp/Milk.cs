using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzApp
{
    class Milk : Condiment
    {
        public Milk(IResource wrappedObject) : base("Milk", wrappedObject) { }

        public override float Cost()
        {
            return WrappedObject.Cost() + 0.20f;
        }

        public override void PrintReceipt()
        {
            WrappedObject.PrintReceipt();
            Console.WriteLine("\tMilk\t0.20");
        }
    }
}
