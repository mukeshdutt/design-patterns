using System;

namespace Prototype
{
    public class Typist : IEmployee
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public IEmployee clone()
        {
            return this.MemberwiseClone() as IEmployee;
        }

        public string GetDetails()
        {
            return "this is information of typist";
        }
    }
}