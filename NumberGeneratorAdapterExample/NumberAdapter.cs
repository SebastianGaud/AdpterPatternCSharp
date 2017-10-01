using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGeneratorAdapterExample
{
    public class NumberAdapter : NumberGenerator, IStringReader
    {
        public string RequestNumber()
        {
            return Convert.ToString(GetNumber());
        }
    }
}
