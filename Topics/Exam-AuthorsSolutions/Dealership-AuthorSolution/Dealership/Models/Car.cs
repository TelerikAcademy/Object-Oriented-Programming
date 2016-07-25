using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System.Text;

namespace Dealership.Models
{
    public class Car : Vehicle, ICar
    {
        private const string SeatsProperty = "Seats";

        private readonly int seats;

        public Car(string make, string model, decimal price, int seats)
            : base(make, model, price, VehicleType.Car)
        {
            this.seats = seats;

            this.ValidateFields();
        }

        public int Seats
        {
            get
            {
                return this.seats;
            }
        }

        protected override string PrintAdditionalInfo()
        {
            return string.Format("  {0}: {1}", SeatsProperty, this.Seats);
        }

        private void ValidateFields()
        {
            Validator.ValidateIntRange(this.seats, Constants.MinSeats, Constants.MaxSeats, string.Format(Constants.NumberMustBeBetweenMinAndMax, SeatsProperty, Constants.MinSeats, Constants.MaxSeats));
        }
    }
}
