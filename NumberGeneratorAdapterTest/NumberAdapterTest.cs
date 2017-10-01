using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberGeneratorAdapterExample;

namespace NumberGeneratorAdapterTest
{
    [TestClass]
    public class NumberAdapterTest
    {
        [TestMethod]
        public void NumberAdapterReturnsNumber()
        {
            var adapter = new NumberAdapter();
            
            Assert.IsTrue(int.TryParse(adapter.RequestNumber(), out int _));
        }
    }
}
