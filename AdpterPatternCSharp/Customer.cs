using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdpterPatternCSharp
{
    public class Customer : Contact
    {
        private string _fullName;

        public Customer(string fullName)
        {
            _fullName = fullName;
        }

        public override string FullName { get => _fullName; }
    }
}
