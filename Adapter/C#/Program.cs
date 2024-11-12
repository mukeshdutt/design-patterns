using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new EmployeeAdapter();
            ThiredPartyBillingSystem client = new ThiredPartyBillingSystem(target);

            client.ShowEmployees();
        }
    }
}
