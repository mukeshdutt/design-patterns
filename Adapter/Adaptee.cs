namespace Adapter
{
    public class HRSystem
    {
        public string[][] GetEmployeeList()
        {
            string[][] employees = new string[4][];

            employees[0] = new string[] { "100", "Mukesh", "Developer" };
            employees[1] = new string[] { "101", "Deepak", "QA Engineer" };
            employees[2] = new string[] { "102", "Rahul", "Engineer" };
            employees[3] = new string[] { "103", "Sanjay", "Team Leader" };
            return employees;
        }
    }
}