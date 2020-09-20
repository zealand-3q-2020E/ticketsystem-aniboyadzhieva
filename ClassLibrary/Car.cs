using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car : Vehicle

    {
        /// <summary>
        /// method Price
        /// </summary>
        /// <returns>fixed price 240 as double</returns>
        public override double Price()
        {
            return 240;
        }

        /// <summary>
        /// method VehicleType
        /// </summary>
        /// <returns>string "Car"</returns>
        public override string VehicleType()
        {
            return "Car";
        }

        public Car(string licensePlate) : base(licensePlate)
        {
        }

        public Car()
        {
        }
    }
}
