using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzApp
{
    class Soy : Condiment
    {
        public Soy(IResource wrappedObject) : base("Soy", wrappedObject) { }

        public override float Cost()
        {
            return WrappedObject.Cost() + 0.05f;
        }

        public override void PrintReceipt()
        {
            WrappedObject.PrintReceipt();
            Console.WriteLine("\tSoy\t0.05");
        }
    }
}
