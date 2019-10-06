using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzApp
{
    class HouseBlend : Beverage
    {
        public HouseBlend() : base("A Nice, Hot Coffee") { }

        public override float Cost()
        {
            return 0.99f;
        }
    }
}
