using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreator creator = new Creator();
            IEmployee emp = creator.Factory("IBM");

            emp.GetAccountDetails();
            emp.GetBasicDetails();
        }
    }
}
