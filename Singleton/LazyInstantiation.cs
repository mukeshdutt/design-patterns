namespace Singleton
{
    public sealed class LazyInstantiation
    {
        public static LazyInstantiation Instance { get { return Nested.Instance; } }

        private LazyInstantiation() { }

        public class Nested
        {
            static Nested() { }

            public static readonly LazyInstantiation Instance = new LazyInstantiation();
        }
    }
}