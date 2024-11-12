namespace Builder
{
    // Abstract Builder
    public interface IVehicleBuilder
    {
        void SetBody();
        void SetModel();
        void SetEngine();
        void SetTransmission();
        void SetAccessories();
        Vehicle GetVehicle();
    }
}