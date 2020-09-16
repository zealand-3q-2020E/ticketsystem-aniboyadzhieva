using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car : Vehicle

    {
        /// <summary>
        /// property for License Plate
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// property for Date
        /// </summary>
        public DateTime Date { get; set; }


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
    }
}
