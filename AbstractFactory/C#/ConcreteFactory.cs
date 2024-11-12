using System;

namespace AbstractFactory
{
    public class Samsung : IPhoneFactory
    {
        public IDump Dump()
        {
            return new Dump();
        }

        public ISmart Smart()
        {
            return new Samrt();
        }
    }

    public class Nokia : IPhoneFactory
    {
        public IDump Dump()
        {
            return new Dump();
        }

        public ISmart Smart()
        {
            return new Samrt();
        }
    }

    public class Moto : IPhoneFactory
    {
        public IDump Dump()
        {
            return new Dump();
        }

        public ISmart Smart()
        {
            return new Samrt();
        }
    }
}