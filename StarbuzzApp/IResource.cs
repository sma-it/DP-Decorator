using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzApp
{
    interface IResource
    {
        string Description { get; }
        float Cost();

        // extra fancy!
        void PrintReceipt();
    }
}
