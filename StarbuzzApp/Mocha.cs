using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzApp
{
    class Mocha : Condiment
    {
        public Mocha(IResource wrappedObject) : base("Mocha", wrappedObject) { }

        public override float Cost()
        {
            return WrappedObject.Cost() + 0.10f;
        }

        public override void PrintReceipt()
        {
            WrappedObject.PrintReceipt();
            Console.WriteLine("\tMocha\t0.10");
        }
    }
}
