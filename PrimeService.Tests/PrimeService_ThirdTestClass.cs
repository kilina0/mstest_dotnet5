using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace Prime.UnitTests.Services
{
    public class PrimeService_ThirdTestClass
    {
        [Fact]
        [TestCategory("Second category")]
        [TestCategory("First category")]
        [TestCategory("Simple")]
        [Priority(2)]
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
