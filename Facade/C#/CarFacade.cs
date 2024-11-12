namespace Facade
{
    public class CarFacade
    {
        CarModel carModel;
        CarEngine carEngine;
        CarBody carBody;
        CarAccessories carAccessories;

        public CarFacade()
        {
            carModel = new CarModel();
            carEngine = new CarEngine();
            carBody = new CarBody();
            carAccessories = new CarAccessories();
        }

        public void CreateCompleteCar()
        {
            carModel.SetModel();
            carBody.SetBody();
            carEngine.SetEngine();
            carAccessories.SetAccessories();
        }
    }
}