namespace AbstractFactory
{
    public interface IDump
    {
        string GetName(string name);
    }

    public interface ISmart
    {
        string GetModelNumber(string model);
    }
}