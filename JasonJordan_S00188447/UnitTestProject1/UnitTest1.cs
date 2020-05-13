using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JasonJordan_S00188447;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPercentageIncrease()
        {

            //ARRANGE
            Phone phone1 = new Phone();
            decimal expectedphonePrice = 220m;


            //ACT
            phone1.Price = 200;
            phone1.IncreasePrice(10);
            


            //ASSERT
            Assert.AreEqual(expectedphonePrice, phone1.Price);
        }
    }
}
