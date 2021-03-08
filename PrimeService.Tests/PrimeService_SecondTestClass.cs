using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace Prime.UnitTests.Services
{
    public class PrimeService_SecondTestClass
    {
        [Fact]
        [TestCategory("Second category")]
        [TestCategory("First category")]
        public void PassingTest()
        {
            Assert.Equal(4, Decimal.Add(2, 2));
            
        }
        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Decimal.Add(2, 2));
        }
        
    }
}
