using System;

namespace Builder
{
    // Concrete Builder
    public class HeroBuilder : IVehicleBuilder
    {
        Vehicle _vehicle = new Vehicle();

        public Vehicle GetVehicle()
        {
            return _vehicle;
        }

        public void SetAccessories()
        {
            _vehicle.Accessories.Add("Seat Cover");
            _vehicle.Accessories.Add("Rear Mirror");
        }

        public void SetBody()
        {
            _vehicle.Body = "Plastic";
        }

        public void SetEngine()
        {
            _vehicle.Engine = "4 Stroke";
        }

        public void SetModel()
        {
            _vehicle.Model = "Hero";
        }

        public void SetTransmission()
        {
            _vehicle.Transmission = "120 km/hr";
        }
    }
}