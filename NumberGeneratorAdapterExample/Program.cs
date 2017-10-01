using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGeneratorAdapterExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var reader = new StringReaderClient();
            var adapter = new NumberAdapter();

            reader.Read(adapter.RequestNumber());
            reader.PrintValue();
        }
    }
}
