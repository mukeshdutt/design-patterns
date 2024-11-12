using System;

namespace Factory
{
    public class Bus : ITravel
    {
        public string GetDetaiils()
        {
            return "Here is details of bus";
        }

        public string GetListing()
        {
            return "Here is listing of bus";
        }
    }
}