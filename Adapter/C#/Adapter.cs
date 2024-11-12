using System;
using System.Collections.Generic;

namespace Adapter
{
    public class EmployeeAdapter : HRSystem, ITarget
    {
        public List<string> GetEmployee()
        {
            List<string> employeeList = new List<string>();
            var employees = base.GetEmployeeList();

            foreach (string[] employee in employees)
            {
                employeeList.Add($"{employee[0]}, {employee[1]}, {employee[2]}");
            }

            return employeeList;
        }
    }
}