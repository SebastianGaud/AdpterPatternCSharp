using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGeneratorAdapterExample
{
    public class NumberGenerator
    {
        private Random _r;

        public NumberGenerator()
        {
            _r = new Random();
        }

        public int GetNumber()
        {
            return _r.Next();
        }
    }
}
