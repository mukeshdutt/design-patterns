namespace Singleton
{
    // Third version - attempted thread-safety using double-check locking
    
    public sealed class DoubleChecking
    {
        public static DoubleChecking logging = null;
        public static readonly object obj = new object();

        private DoubleChecking() { }

        public static DoubleChecking GetInstance()
        {
            if (logging == null)
            {
                lock (obj)
                {
                    if (logging == null)
                        logging = new DoubleChecking();             
                }
            }

            return logging;
        }
    }
}