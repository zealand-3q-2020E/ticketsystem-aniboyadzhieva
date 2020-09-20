using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MC : Vehicle
    {
        public MC(string licensePlate) : base(licensePlate)
        {
        }

        public MC()
        {

        }

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
