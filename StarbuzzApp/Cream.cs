using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzApp
{
    class Cream : Condiment
    {
        public Cream(IResource wrappedObject) : base("Cream", wrappedObject) { }

        public override float Cost()
        {
            return WrappedObject.Cost() + 0.50f;
        }

        public override void PrintReceipt()
        {
            WrappedObject.PrintReceipt();
            Console.WriteLine("\tCream\t0.50");
        }
    }
}
