using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTestingUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = CalculatorTestingExample.Operations.Divide(1, 2);
            Assert.IsTrue(result == 0.5);
            var result2 = CalculatorTestingExample.Operations.Divide(3, 3);
            Assert.IsTrue(result2 == 1);
        }
    }
}
