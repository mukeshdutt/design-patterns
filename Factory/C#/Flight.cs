using System;

namespace Factory
{
    public class Flight : ITravel
    {
        public string GetDetaiils()
        {
            return "Here is details of Flight";
        }

        public string GetListing()
        {
            return "Here is listing of Flight";
        }
    }
}