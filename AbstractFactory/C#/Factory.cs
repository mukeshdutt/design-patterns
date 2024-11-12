namespace AbstractFactory
{
    public interface IPhoneFactory
    {
        IDump Dump();
        ISmart Smart();
    }
}