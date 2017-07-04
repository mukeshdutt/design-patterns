using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Logging logging = Logging.GetInstance();
            logging.Name = "mukesh dutt";
            System.Console.WriteLine(logging.Name);

            Logging loggings = Logging.GetInstance();
            loggings.Name = "sanjay";
            System.Console.WriteLine(loggings.Name);

            System.Console.WriteLine("------------Printing old object's value which is changed after another object value change because both have same instance ----------");
            System.Console.WriteLine(logging.Name);        
        }
    }
}
