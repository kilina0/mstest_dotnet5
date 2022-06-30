using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_FifthTestClass
    {
        [TestCategory("Second category")]
        [TestCategory("First category")]
        [TestCategory("Simple")]
        [TestMethod]
        public void PassingTest()
        {
            Console.WriteLine("текст😆😦");
            Console.WriteLine("текст😆😦");
            Console.WriteLine("текст");
            Console.WriteLine("текст😆😦");
            Assert.Equals(4, Decimal.Add(2, 2));
        }

        [TestMethod]
        public void FailingTest()
        {
            Console.WriteLine("текст😆😦");
            Console.WriteLine("текст😆😦");
            Console.WriteLine("текст");
            Console.WriteLine("текст😆😦");
            Assert.Equals(5, Decimal.Add(2, 2));
        }

    }
}
