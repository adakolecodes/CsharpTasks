using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProjection
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public List<Technology> Programming { get; set; }

        public Employee(int employeeId, string fullName, string email, List<Technology> programming)
        {
            EmployeeId = employeeId;
            FullName = fullName;
            Email = email;
            Programming = programming;
        }
    }
}
