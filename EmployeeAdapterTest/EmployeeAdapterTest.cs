using System;
using AdpterPatternCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeAdapterTest;

namespace EmployeeAdapterTest
{
    [TestClass]
    public class EmployeeAdapterTest
    {
        private EmployeeAdapter e;

        public EmployeeAdapterTest()
        {
            this.e = new EmployeeAdapter(new Employee("Riccardo", "Golia")); ;
        }

        [TestMethod]
        public void EmployeeAdapterIsContact()
        {
            Assert.IsTrue(e is Contact);
        }

        [TestMethod]
        public void AdapterDoNotChangeFunctionallity()
        {
            Assert.IsTrue(e.FullName == "Riccardo Golia");
        }
    }
}
