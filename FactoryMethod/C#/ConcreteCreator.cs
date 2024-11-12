using System;

namespace FactoryMethod
{
    public class Creator : ICreator
    {
        public IEmployee Factory(string name)
        {
            switch (name)
            {
                case "IBM":
                 return new IBM();

                case "ACCENTURE":
                 return new Accenture();

                case "OXIGEN":
                 return new Oxigen();
            }

            return null;
        }
    }
}