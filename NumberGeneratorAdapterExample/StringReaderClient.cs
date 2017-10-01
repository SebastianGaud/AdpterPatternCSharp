using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGeneratorAdapterExample
{
    public class StringReaderClient
    {
        private string _readedValue;

        public void Read(string s)
        {
            _readedValue = s;
        }

        public void PrintValue()
        {
            Console.WriteLine($"Value is: {_readedValue}");
        }
    }
}
