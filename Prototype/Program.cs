using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Typist object
            Typist typist1 = new Typist();
            typist1.Name = "hello";
            System.Console.WriteLine(typist1.Name + Environment.NewLine);

            Typist typist = typist1.clone() as Typist;
            System.Console.WriteLine(typist.Name);
            
            typist1.Name = "alok";
            System.Console.WriteLine($"New name of typist1 is : {typist1.Name}\n");
            System.Console.WriteLine($"New name of typist is : {typist.Name}\n");

            // Developer object
            Developer developer1 = new Developer();
            developer1.Name = "hello";
            System.Console.WriteLine(developer1.Name + Environment.NewLine);

            Developer developer = developer1.clone() as Developer;
            System.Console.WriteLine(typist.Name);

            Console.WriteLine("Hello World!");
        }
    }
}
