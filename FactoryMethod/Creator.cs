namespace FactoryMethod
{
    public interface ICreator
    {
        IEmployee Factory(string name);
    }
}