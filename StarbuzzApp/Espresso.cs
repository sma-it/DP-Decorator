using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzApp
{
    class Espresso : Beverage
    {
        public Espresso() : base("Strong Coffee") { }

        public override float Cost()
        {
            return 1.29f;
        }
    }
}
