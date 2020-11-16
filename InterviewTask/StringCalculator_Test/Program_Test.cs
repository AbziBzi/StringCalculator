using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace StringCalculator_Test
{
    [TestClass]
    public class Program_Test
    {
        [TestMethod]
        public void Add_ValidGivenNumber()
        {
            string number = "12";
            int expectedResult = 12;
            int result = Converter.Add(number);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Add_GivenEmptyString()
        {
            string number = "";
            int expectedResult = 0;
            int result = Converter.Add(number);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
