using System;

namespace Factory
{
    public class Hotel : ITravel
    {
        public string GetDetaiils()
        {
            return "Here is details of Hotel";
        }

        public string GetListing()
        {
            return "Here is listing of Hotel";
        }
    }
}