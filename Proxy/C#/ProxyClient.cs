using System;

namespace Proxy
{
    public class ProxyClient : IClient
    {
        RealClient client = new RealClient();

        public string GetData()
        {
            return client.GetData();
        }
    }
}