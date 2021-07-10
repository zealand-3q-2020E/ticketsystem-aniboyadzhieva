using System;
using ClassLibrary;



namespace StoreBaeltTicketLibrary
{
    public class Car : ClassLibrary.Car
    {
        public Car(string licensePlate, bool brobizzDiscount, DateTime date) : base(licensePlate, brobizzDiscount, date)
        {
        }

        public virtual double WeekendDiscountMethod()
        {
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
                return base.Price() * 0.80;
            return base.Price();
        }
    }
}
