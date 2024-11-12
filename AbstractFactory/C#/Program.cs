using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            IPhoneFactory phoneFactory = client.GetInstance(FactoryName.SAMSUNG);
            IDump dump = phoneFactory.Dump();
            string name = dump.GetName("Hey this is SAMSUNG S8");

            ISmart smart = phoneFactory.Smart();
            string modelNumber = smart.GetModelNumber("XT672K");

            System.Console.WriteLine(name + Environment.NewLine);
            System.Console.WriteLine(modelNumber + Environment.NewLine);

            Console.WriteLine("Hello World!");
        }
    }
}
