using System;

namespace Singleton
{
    public sealed class LazyType
    {
        private static readonly Lazy<LazyType> lazy = new Lazy<LazyType>(() => new LazyType());

        public static LazyType Instance { get { return lazy.Value; } }

        private LazyType() { }
    }
}