using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oresundbron;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestOresundbron
    {
        [TestMethod]
        public void TestCarType()
        {
            //Arrange
            Car oresundbronCar = new Car("whatever", false, DateTime.Today);
            //Act
            string actualResult = oresundbronCar.VehicleType();
            //Assert
            Assert.AreEqual("Oresund car", actualResult);
        }

        [TestMethod]
        public void TestCarPrice()
        {
            //Arrange
            Car oresundbronCar = new Car("whatever", false, DateTime.Today);
            //Act
            double actualResult = oresundbronCar.Price();
            //Assert
            Assert.AreEqual(410, actualResult);
        }

        [TestMethod]
        public void TestCarBrobizzDiscount()
        {
            //Arrange
            Car oresundbronCar2 = new Car("smth", true, DateTime.Today);
            //Act
            double actualResult = oresundbronCar2.BrobizzDiscountMethod();
            //Assert
            Assert.AreEqual(161,actualResult);
        }

        [TestMethod]
        public void TestMCType()
        {
            //Arrange
            MC oresundbronMc = new MC("motor", false, DateTime.Today);
            //Act
            string actualResult = oresundbronMc.VehicleType();
            //Assert
            Assert.AreEqual("Oresund MC", actualResult);
        }

        [TestMethod]
        public void TestMCPrice()
        {
            //Arrange
            MC oresundbronMc = new MC("motor", false, DateTime.Today);
            //Act
            double actualResult = oresundbronMc.Price();
            //Assert
            Assert.AreEqual(210, actualResult);
        }

        [TestMethod]
        public void TestMCBrobizzDiscount()
        {
            //Arrange
            MC oresundbronMc2 = new MC("motor2", true, DateTime.Today);
            //Act
            double actualResult = oresundbronMc2.BrobizzDiscountMethod();
            //Assert
            Assert.AreEqual(73, actualResult);
        }

    }
}
