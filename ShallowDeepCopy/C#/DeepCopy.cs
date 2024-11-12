using System;

namespace ShallowDeepCopy
{
    public class DeepCopy : IDeepCopy
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
        public Account account = new Account();

        public IDeepCopy DeepClone()
        {
            DeepCopy clone = this.MemberwiseClone() as DeepCopy;
            clone.account = new Account();
            clone.account.Number = this.account.Number;
            clone.account.Pan = this.account.Pan;
            return clone as IDeepCopy;
        }
    }
}