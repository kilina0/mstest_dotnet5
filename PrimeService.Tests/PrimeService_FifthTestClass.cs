using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_FifthTestClass
    {
        [TestCategory("FifthCategory")]
        [TestMethod]
        public void PassingTest()
        {
            Console.WriteLine("текст😆😦");
            Console.WriteLine("текст😆😦");
            Console.WriteLine("[runtime] 2022-06-30 08:17:37 [verbose]: 📺 ScreenTestScene(OsuScreenStack)#296(depth:1) loading TestMultiplayerComponents#150");
            Console.WriteLine("[runtime] 2022-06-30 08:17:37 [verbose]: 📺 ScreenTestScene(OsuScreenStack)#296(depth:1) loading TestMultiplayerComponents#150");
            Console.WriteLine("[runtime] 2022-06-30 08:17:37 [verbose]: 📺 ScreenTestScene(OsuScreenStack)#296(depth:1) loading TestMultiplayerComponents#150");
            Console.WriteLine("текст");
            Console.WriteLine("текст😆😦");
            Assert.Equals(4, Decimal.Add(2, 2));
        }

        [TestMethod]
        public void FailingTest()
        {
            Console.WriteLine("текст😆😦");
            Console.WriteLine("текст😆😦");
            Console.WriteLine("[runtime] 2022-06-30 08:17:37 [verbose]: 📺 ScreenTestScene(OsuScreenStack)#296(depth:1) loading TestMultiplayerComponents#150");
            Console.WriteLine("[runtime] 2022-06-30 08:17:37 [verbose]: 📺 ScreenTestScene(OsuScreenStack)#296(depth:1) loading TestMultiplayerComponents#150");
            Console.WriteLine("[runtime] 2022-06-30 08:17:37 [verbose]: 📺 ScreenTestScene(OsuScreenStack)#296(depth:1) loading TestMultiplayerComponents#150");

            Console.WriteLine("текст");
            Console.WriteLine("текст😆😦");
            Assert.Equals(5, Decimal.Add(2, 2));
        }

    }
}
