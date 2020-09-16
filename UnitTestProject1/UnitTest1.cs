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
            Car.Price();
            //Act
            double actualResult = Car.Price();
            //Assert
            Assert.AreEqual(240, actualResult);
        }


        [TestMethod]
        public void TestCarVehicleTypeMethod()
        {
            //Arrange
            Car.VehicleType();
            //Act
            string actualResult = Car.VehicleType();
            //Assert
            Assert.AreEqual("Car", actualResult);
        }

        [TestMethod]
        public void TestMCPriceMethod()
        {
            //Arrange
            MC.Price();
            //Act
            double actualResult = MC.Price();
            //Assert
            Assert.AreEqual(125, actualResult);
        }

        [TestMethod]
        public void TestMCVehicleTypeMethod()
        {
            //Arrange
            MC.VehicleType();
            //Act
            string actualResult = MC.VehicleType();
            //Assert
            Assert.AreEqual("MC", actualResult);
        }

    }
}
