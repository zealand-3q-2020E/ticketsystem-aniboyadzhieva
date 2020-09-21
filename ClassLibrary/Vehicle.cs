using System;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        private string licensePlate;
        private string brobizzDiscount;

        /// <summary>
        /// default Vehicle constructor
        /// </summary>
        public Vehicle()
        {

        }

        /// <summary>
        /// Vehicle constructor - includes the functionality about the length of the license plate
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="brobizzDiscount"></param>
        public Vehicle(string licensePlate, bool brobizzDiscount)
        {
            LicensePlate = licensePlate;
            BrobizzDiscount = brobizzDiscount;

            if (licensePlate.Length > 8)
                throw new Exception("License plate must not contain more than 8 characters");
        }

        /// <summary>
        /// LicensePlate property - string
        /// </summary>
        public string LicensePlate { get; }

        /// <summary>
        /// BrobizzDiscount property - bool
        /// </summary>
        public bool BrobizzDiscount { get; set; }


        /// <summary>
        /// property for Date
        /// </summary>
        public DateTime Date { get; set; }


        /// <summary>
        /// Price method
        /// </summary>
        /// <returns>double 240</returns>
        public virtual double Price()
        {
            return 240;
        }

        /// <summary>
        /// BrobizzDiscountMethod method
        /// </summary>
        /// <returns>price with brobizz discount or the regular one</returns>
        public virtual double BrobizzDiscountMethod()
        {
            if (BrobizzDiscount)
                return Price() * 0.95;
            return Price();
        }

        /// <summary>
        /// VehicleType method - only overrides are used
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();
        

    }
}
