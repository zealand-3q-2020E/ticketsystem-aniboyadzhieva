using System;
using ClassLibrary;

namespace Oresundbron
{
    public class Car : ClassLibrary.Car
    {
        public Car(string licensePlate, bool brobizzDiscount, DateTime date) : base(licensePlate, brobizzDiscount, date)
        {
           
        }

        public override double Price()
        {
            return 410;
        }

        public override double BrobizzDiscountMethod()
        {
            if (BrobizzDiscount)
                return 161;
            return Price();
        }

        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
