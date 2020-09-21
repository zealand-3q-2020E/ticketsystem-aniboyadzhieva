using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MC : Vehicle
    {
        /// <summary>
        /// override method VehicleType
        /// </summary>
        /// <returns>string "MC"</returns>
        public override string VehicleType()
        {
            return "MC";
        }

        /// <summary>
        /// override Price method
        /// </summary>
        /// <returns>double 125</returns>
        public override double Price()
        {
            return 125;
        }

        /// <summary>
        /// MC constructor that inherits from the base class constructor
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="brobizzDiscount"></param>
        public MC(string licensePlate, bool brobizzDiscount, DateTime date) : base(licensePlate, brobizzDiscount, date)
        {
        }

        /// <summary>
        /// default MC constructor
        /// </summary>
        public MC() : base()
        {

        }
    }
}
