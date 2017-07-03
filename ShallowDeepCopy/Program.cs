using System;

namespace ShallowDeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shallow copy simply we can achive using MemberWiseClone() but it is working with
            // only value type but when talk about reference type we use deep copy where be create 
            // explicitly create object all reference type class

            // Shallow example
            Shallow sh1 = new Shallow();
            sh1.Name = "mukesh dutt";
            sh1.Mobile = "9717915661";

            // Cloning the previous object into new class
            Shallow sh2 = sh1.Clone() as Shallow;
            sh2.Name = "alok singh";
            sh2.Mobile = "9878778788";

            System.Console.WriteLine("-------------Shallow Copy-------------");
            System.Console.WriteLine($"Name : {sh1.Name} ");
            System.Console.WriteLine($"Mobile : {sh1.Mobile} ");

            System.Console.WriteLine("---------After copied and change cloned data previous values are still remain--------");
            System.Console.WriteLine($"Name : {sh1.Name} ");
            System.Console.WriteLine($"Mobile {sh1.Mobile} ");

            // Deep copy example
            DeepCopy de1 = new DeepCopy();
            de1.Name = "mukesh dutt";
            de1.Mobile = "9717915661";
            de1.account.Number = "102121";
            de1.account.Pan = "ASAJKFJSK12";

            // Cloning the previous object into new class
            DeepCopy de2 = de1.DeepClone() as DeepCopy;
            de2.Name = "alok singh";
            de2.Mobile = "9878778788";
            de2.account.Number = "32102121";
            de2.account.Pan = "43JSK12";

            System.Console.WriteLine("-------------------Deep Copy-------------------");
            System.Console.WriteLine($"Name : {de1.Name} ");
            System.Console.WriteLine($"Mobile : {de1.Mobile} ");
            System.Console.WriteLine($"Account number : {de1.account.Number} ");
            System.Console.WriteLine($"Pan details : {de1.account.Pan} ");

            System.Console.WriteLine("---------After copied and change cloned data previous values are still remain--------");
            System.Console.WriteLine($"Name : {de1.Name} ");
            System.Console.WriteLine($"Mobile : {de1.Mobile} ");
            System.Console.WriteLine($"Account number : {de1.account.Number} ");
            System.Console.WriteLine($"Pan : {de1.account.Pan}");
        }
    }
}
