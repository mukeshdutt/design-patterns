using System;

namespace Prototype
{
    public class Developer
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public Developer clone()
        {
            return this.MemberwiseClone() as Developer;
        }

        public string GetDetails()
        {
            return "this is information of typist";
        }
    }
}