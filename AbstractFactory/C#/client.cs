namespace AbstractFactory
{
    public enum FactoryName
    {
        SAMSUNG,
        NOKIA,
        MOTO
    }

    public class Client
    {
        public IPhoneFactory GetInstance(FactoryName factoryName)
        {
            switch (factoryName)
            {
                case FactoryName.SAMSUNG:
                    return new Samsung();

                case FactoryName.NOKIA:
                    return new Samsung();

                case FactoryName.MOTO:
                    return new Samsung();
            }
            return null;
        }
    }
}