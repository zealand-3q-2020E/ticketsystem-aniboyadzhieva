using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCarPriceMethod()
        {
            //Arrange
            Car car1 = new Car();
            //Act
            double actualResult = car1.Price();
            //Assert
            Assert.AreEqual(240, actualResult);
        }


        [TestMethod]
        public void TestCarVehicleTypeMethod()
        {
            //Arrange
            Car car2 = new Car();
            //Act
            string actualResult = car2.VehicleType();
            //Assert
            Assert.AreEqual("Car", actualResult);
        }

        [TestMethod]
        public void TestMCPriceMethod()
        {
            //Arrange
            MC mc1 = new MC();
            //Act
            double actualResult = mc1.Price();
            //Assert
            Assert.AreEqual(125, actualResult);
        }

        [TestMethod]
        public void TestMCVehicleTypeMethod()
        {
            //Arrange
            MC mc2 = new MC();
            //Act
            string actualResult = mc2.VehicleType();
            //Assert
            Assert.AreEqual("MC", actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestLicensePlateLenght()
        {
            //Arrange
            MC mc3 = new MC("CA28035RF");
            //Act
            string actualResult = mc3.VehicleType();
            //Assert
            Assert.AreEqual("MC", actualResult);
        }

    }
}
