﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car
    {
        private static double _price;
        private static string _type;

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
            _price = 240;
            return _price;
        }

        /// <summary>
        /// method VehicleType
        /// </summary>
        /// <returns>string "Car"</returns>
        public static string VehicleType()
        {
            _type = "Car";
            return _type;
        }
    }
}
