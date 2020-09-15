using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car
    {
        private static int price;
        private static string type;

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
        public static double Price()
        {
            price = 240;
            return price;
        }

        /// <summary>
        /// method VehicleType
        /// </summary>
        /// <returns>string "Car"</returns>
        public static string VehicleType()
        {
            type = "Car";
            return type;
        }
    }
}
