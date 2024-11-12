using System;

namespace ExtensionMethod
{
    public class Employee
    {
        public void GetEmployeeBasicInfo()
        {
            System.Console.WriteLine("Hey this is mukesh dutt \n");
        }
    }

    public static class Account
    {
        public static void GetEmployeeAccountDetails(this Employee emp, string name)
        {
            System.Console.WriteLine($"customer account details of {name} \n");
        }
    }
}