using System;
using System.Collections.Generic;
using System.Text;
using StoreBaeltTicketLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestStoreBaeltTicketLibrary
    {
        [TestMethod]
        public void TestCarWeekendDiscountMethodSaturday()
        {
            //Arrange
            Car newCar = new Car("BG2356K", true, new DateTime(2020, 09,19));
            //Act
            double actualResult = newCar.WeekendDiscountMethod();
            //Assert
            Assert.AreEqual(192, actualResult);
        }

        [TestMethod]
        public void TestCarWeekendDiscountMethodSunday()
        {
            //Arrange
            Car newCar = new Car("BG2356K", true, new DateTime(2020, 09, 20));
            //Act
            double actualResult = newCar.WeekendDiscountMethod();
            //Assert
            Assert.AreEqual(192, actualResult);
        }

    }
}
