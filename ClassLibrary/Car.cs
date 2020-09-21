using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car : Vehicle

    {
        /// <summary>
        /// override method VehicleType
        /// </summary>
        /// <returns>string "Car"</returns>
        public override string VehicleType()
        {
            return "Car";
        }


        /// <summary>
        /// Car constructor that inherits from the base class constructor
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="brobizzDiscount"></param>
        public Car(string licensePlate, bool brobizzDiscount, DateTime date) : base(licensePlate, brobizzDiscount, date)
        {
        }

        /// <summary>
        /// default Car constructor
        /// </summary>
        public Car() : base()
        {
        }
    }
}
