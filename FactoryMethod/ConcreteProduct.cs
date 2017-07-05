using System;

namespace FactoryMethod
{
    public class Oxigen : IEmployee
    {
        public void GetAccountDetails()
        {
            System.Console.WriteLine("Ive an account in HDFC Bank - Oxigen");
        }

        public void GetBasicDetails()
        {
            System.Console.WriteLine("I'm an employee of oxigen");
        }
    }

    public class Accenture : IEmployee
    {
        public void GetAccountDetails()
        {
            System.Console.WriteLine("Ive an account in IDBI Bank - Accenture");
        }

        public void GetBasicDetails()
        {
            System.Console.WriteLine("I'm an employee of Accenture");
        }
    }

    public class IBM : IEmployee
    {
        public void GetAccountDetails()
        {
            System.Console.WriteLine("Ive an account in ICICI Bank - IBM");
        }

        public void GetBasicDetails()
        {
            System.Console.WriteLine("I'm an employee of IBM");
        }
    }

    
}