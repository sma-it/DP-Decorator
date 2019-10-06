using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzApp
{
    abstract class Condiment : IResource
    {
        string description;
        public string Description => description;

        IResource wrappedObject;
        public IResource WrappedObject => wrappedObject;

        public Condiment(string description, IResource wrappedObject)
        {
            this.description = description;
            this.wrappedObject = wrappedObject;
        }

        public abstract float Cost();

        public abstract void PrintReceipt();
    }
}
