namespace LibraryManagementSystem.Models
{
    internal class Employee:Person
    {
        public Employee(int employeeId, string firstName, string lastName):base(firstName, lastName)
        {
            if (employeeId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(employeeId));
            }
            EmployeeId = employeeId;
        }
        public int EmployeeId { get;}
    }
}
