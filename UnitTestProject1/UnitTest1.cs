using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPriceMethod()
        {
            //Arrange
            Car.Price();
            //Act
            double actualResult = Car.Price();
            //Assert
            Assert.AreEqual(240, actualResult);
        }


        [TestMethod]
        public void TestVehicleTypeMethod()
        {
            //Arrange
            Car.VehicleType();
            //Act
            string actualResult = Car.VehicleType();
            //Assert
            Assert.AreEqual("Car", actualResult);
        }

    }
}
