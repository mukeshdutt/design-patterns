namespace Singleton
{
    // Second version - simple thread-safety
    public sealed class LoggingThreadSafe
    {
        public static LoggingThreadSafe logging = null;
        public static object obj = new object();

        private LoggingThreadSafe() { }

        public static LoggingThreadSafe GetInstance()
        {
            lock (obj)
            {
                if (logging == null)
                    logging = new LoggingThreadSafe();

                return logging;
            }
        }
    }
}