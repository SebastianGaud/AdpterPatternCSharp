using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdpterPatternCSharp
{
    public class Employee
    {
        private int _firstName;

        public int FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private int _lastName;

        public int LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public Employee(int firstName, int lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
    }
}
