using System;

namespace ShallowDeepCopy
{
    public class Shallow : IShallow
    {
        public string Name { get; set; }
        public string Mobile { get; set; }

        public IShallow Clone()
        {
            return this.MemberwiseClone() as Shallow;
        }
    }
}