using System;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        private string licensePlate;

        public Vehicle()
        {

        }

        public Vehicle(string licensePlate)
        {
            LicensePlate = licensePlate; 
            
                if (licensePlate.Length > 8)
                    throw new Exception("License plate must not contain more than 8 characters");
            
        }


        public string LicensePlate { get; }

        /// <summary>
        /// property for Date
        /// </summary>
        public DateTime Date { get; set; }

        public abstract double Price();
        public abstract string VehicleType();

    }
}
