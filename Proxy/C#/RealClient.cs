using System;

namespace Proxy
{
    public class RealClient : IClient
    {
        public string GetData()
        {
            return "Hey this is collection of design pattern";
        }
    }
}