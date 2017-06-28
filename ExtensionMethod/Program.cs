using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.GetEmployeeBasicInfo();
            emp.GetEmployeeAccountDetails("mukeshdutt");

            Console.WriteLine("Hello World!");
        }
    }
}
