using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MC : Vehicle
    {
        /// <summary>
        /// property LicensePlate
        /// </summary>
        public string LicensePlate { get; set; }
        /// <summary>
        /// property Date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// method Price
        /// </summary>
        /// <returns>fixed double price 125</returns>
        public override double Price()
        {
            return 125;
        }

        /// <summary>
        /// method VehicleType
        /// </summary>
        /// <returns>string "MC"</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
