namespace Singleton
{
    // Fourth version - not quite as lazy, but thread-safe without using locks
    public sealed class WithoutLock
    {
        public static readonly WithoutLock logging = new WithoutLock(); 
        static WithoutLock() { }

        private WithoutLock() { }

        public string Name { get; set; }

        public static WithoutLock GetInstance()
        {
            return logging;
        }
    }
}