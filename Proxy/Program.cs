using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyClient client = new ProxyClient();
            var response = client.GetData();

            System.Console.WriteLine(response);
        }
    }
}
