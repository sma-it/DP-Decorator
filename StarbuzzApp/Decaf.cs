using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzApp
{
    class Decaf : Beverage
    {
        public Decaf() : base("No Coffee") { }

        public override float Cost()
        {
            return 1.59f;
        }
    }
}
