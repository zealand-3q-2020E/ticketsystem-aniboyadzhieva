using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MC
    {
        private static double _price;
        private static string _vehicle;

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
        public static double Price()
        {
            _price = 125;
            return _price;
        }

        /// <summary>
        /// method VehicleType
        /// </summary>
        /// <returns>string "MC"</returns>
        public static string VehicleType()
        {
            _vehicle = "MC";
            return _vehicle;
        }
    }
}
