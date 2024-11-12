namespace Builder
{
    // It is creator or director it played the main role in builder pattern because it executes 
    // Process sequentially
    // It is also called DIRECTOR

    public class VehicleCreator
    {
        private readonly IVehicleBuilder _vehicleBuilder;

        public VehicleCreator(IVehicleBuilder vehicleCreator)
        {
            _vehicleBuilder = vehicleCreator;
        }

        public void CreateVehicle()
        {
            _vehicleBuilder.SetBody();
            _vehicleBuilder.SetAccessories();
            _vehicleBuilder.SetEngine();
            _vehicleBuilder.SetModel();
            _vehicleBuilder.SetTransmission();
        }

        public Vehicle GetVehicle()
        {
            return _vehicleBuilder.GetVehicle();
        }
    }
}