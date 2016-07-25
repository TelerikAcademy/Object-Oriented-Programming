using System.Text;
using Dealership.Common.Enums;
using Dealership.Contracts;
using Dealership.Common;
using System;

namespace Dealership.Models
{
    public class Truck : Vehicle, ITruck
    {
        private const string WeightCapacityPropery = "Weight capacity";

        private readonly int weightCapacity;

        public Truck(string make, string model, decimal price, int weightCapacity)
            : base(make, model, price, VehicleType.Truck)
        {
            this.weightCapacity = weightCapacity;

            this.ValidateFields();
        }

        public int WeightCapacity
        {
            get
            {
                return this.weightCapacity;
            }
        }

        protected override string PrintAdditionalInfo()
        {
            // Е mnoo sum gaden! Za edna glavna bukva! ЦЦЦЦЦЦЦ :D
            return string.Format("  Weight Capacity: {0}t", this.WeightCapacity);
        }

        private void ValidateFields()
        {
            Validator.ValidateIntRange(this.weightCapacity, Constants.MinCapacity, Constants.MaxCapacity, string.Format(Constants.NumberMustBeBetweenMinAndMax, WeightCapacityPropery, Constants.MinCapacity, Constants.MaxCapacity));
        }
    }
}
