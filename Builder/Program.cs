using System;

// Seperate object construction from it's representation
namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using HondaBuilder
            VehicleCreator director = new VehicleCreator(new HondaBuilder());
            director.CreateVehicle();

            // Getting vehicle information of HondaBuilder
            var vehicle = director.GetVehicle();
            vehicle.ShowInfo();

            Console.WriteLine("---------------------------------------------");

            // Using Hero Builder
            director = new VehicleCreator(new HeroBuilder());
            director.CreateVehicle();
            director.GetVehicle();

            // Getting vehicle information of HeroBuilder
            vehicle = director.GetVehicle();
            vehicle.ShowInfo();
        }
    }
}
