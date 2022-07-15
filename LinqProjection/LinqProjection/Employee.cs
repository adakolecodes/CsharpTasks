using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProjection
{
    internal class Employee
    {
        public int _employeeId { get; set; }
        public string _fullName { get; set; }
        public string _email { get; set; }
        public List<Technology> _programming { get; set; }

        public Employee(int employeeId, string fullName, string email, List<Technology> programming)
        {
            _employeeId = employeeId;
            _fullName = fullName;
            _email = email;
            _programming = programming;
        }
    }
}
