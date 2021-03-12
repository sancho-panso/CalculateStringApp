using ConsoleApp3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateStringTest
{
    [TestClass]
    public class CalculateTest
    {
        private const string inputString= "* 20 20"; 
        [TestMethod]
        public void TestMethod1()
        {
            var result = Program.Calculate(inputString);

            Assert.AreEqual(result, 400);
        }
    }
}
