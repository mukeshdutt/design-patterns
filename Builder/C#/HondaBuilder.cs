using System;

namespace Builder
{
    // Concrete Builder
    public class HondaBuilder : IVehicleBuilder
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
            _vehicle.Accessories.Add("Bike Cover");
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
            _vehicle.Model = "Honda";
        }

        public void SetTransmission()
        {
            _vehicle.Transmission = "130 km/hr";
        }
    }
}