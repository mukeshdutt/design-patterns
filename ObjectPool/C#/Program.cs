using System;

namespace ObjectPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Action closure = () => { 
                System.Console.WriteLine("Hey this is mukesh");
            };

            closure();
        }
    }
}
