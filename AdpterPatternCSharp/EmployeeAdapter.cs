using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdpterPatternCSharp
{
    public class EmployeeAdapter : Contact
    {
        private readonly Employee _employee;

        public EmployeeAdapter(Employee employee)
        {
            _employee = employee;
        }

        public override string FullName
        {
            get { return _employee.FirstName + " " + _employee.LastName; }
        }
    }
}
