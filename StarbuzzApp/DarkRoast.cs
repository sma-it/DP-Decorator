using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzApp
{
    class DarkRoast : Beverage
    {
        public DarkRoast() : base("Dark Coffee") { }

        public override float Cost()
        {
            return 1.99f;
        }
    }
}
