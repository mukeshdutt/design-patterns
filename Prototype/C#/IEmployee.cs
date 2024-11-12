namespace Prototype
{
    public interface IEmployee
    {
        IEmployee clone();
        string GetDetails();
    }
}