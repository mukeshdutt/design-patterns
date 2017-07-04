using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here is an implementation of factory design pattern according to GOF this does not come under design pattern
            // But this is the concept to create common method at same place using an interface or abstract class 
            // and who need these methods they can implement according to their need

            // Creating instace for bus
            ITravel bus = new Bus();
            System.Console.WriteLine(bus.GetListing());
            System.Console.WriteLine(bus.GetDetaiils());

            // Creating instance for hotel
            ITravel hotel = new Hotel();
            System.Console.WriteLine(hotel.GetListing());
            System.Console.WriteLine(hotel.GetDetaiils());

            // Creating instace for flight
            ITravel flight = new Flight();
            System.Console.WriteLine(flight.GetListing());
            System.Console.WriteLine(flight.GetDetaiils());
        }
    }
}
