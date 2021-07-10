using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace Oresundbron
{
    public class MC : ClassLibrary.MC
    {
        public MC(string licensePlate, bool brobizzDiscount, DateTime date) : base(licensePlate, brobizzDiscount, date)
        {

        }

        public override double Price()
        {
            return 210;
        }

        public override double BrobizzDiscountMethod()
        {
            if (BrobizzDiscount)
                return 73;
            return Price();
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
