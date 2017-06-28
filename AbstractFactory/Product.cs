using System;

namespace AbstractFactory
{
    public class Dump : IDump
    {
        public string GetName(string name)
        {
            return $"Hey you got {name} mobile";
        }
    }

    public class Samrt : ISmart
    {
        public string GetModelNumber(string model)
        {
            return $"Hey you got brand new model which is : {model}";
        }
    }
}