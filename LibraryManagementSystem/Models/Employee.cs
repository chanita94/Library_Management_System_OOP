using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Employee:Person
    {
        public Employee(int employeeSsn, string firstName, string lastName):base(firstName, lastName)
        {
            EmployeeSSN= employeeSsn;
        }
        public int EmployeeSSN { get;}
    }
}
