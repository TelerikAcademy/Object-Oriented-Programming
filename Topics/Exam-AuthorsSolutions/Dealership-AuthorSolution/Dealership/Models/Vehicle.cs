using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Models
{
    public abstract class Vehicle : IVehicle, ICommentable
    {
        private const string MakeProperty = "Make";
        private const string ModelProperty = "Model";
        private const string PriceProperty = "Price";
        private const string WheelsProperty = "Wheels";
        private const string CommentsHeader = "    --COMMENTS--";
        private const string NoCommentsHeader = "    --NO COMMENTS--";

        private readonly string make;
        private readonly string model;
        private readonly decimal price;
        private readonly int wheels;

        public Vehicle(string make, string model, decimal price, VehicleType type)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.Type = type;
            this.wheels = (int)type;
            this.Comments = new List<IComment>();

            this.ValidateFields();
        }

        public VehicleType Type { get; protected set; }

        public int Wheels
        {
            get
            {
                return this.wheels;
            }
        }

        public string Make
        {
            get
            {
                return this.make;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public IList<IComment> Comments { get; private set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(string.Format("{0}:", this.GetType().Name));
            builder.AppendLine(string.Format("  {0}: {1}", MakeProperty, this.Make));
            builder.AppendLine(string.Format("  {0}: {1}", ModelProperty, this.Model));
            builder.AppendLine(string.Format("  {0}: {1}", WheelsProperty, this.Wheels));
            builder.AppendLine(string.Format("  {0}: ${1}", PriceProperty, this.Price));
            builder.AppendLine(this.PrintAdditionalInfo());
            builder.AppendLine(this.PrintComments());
            return builder.ToString().TrimEnd();
        }

        protected abstract string PrintAdditionalInfo();

        private string PrintComments()
        {
            var builder = new StringBuilder();

            if (this.Comments.Count <= 0)
            {
                builder.AppendLine(string.Format("{0}", NoCommentsHeader));
            }
            else
            {
                builder.AppendLine(string.Format("{0}", CommentsHeader));

                foreach (var comment in this.Comments)
                {
                    builder.AppendLine(comment.ToString());
                }

                builder.AppendLine(string.Format("{0}", CommentsHeader));
            }

            return builder.ToString().TrimEnd();
        }

        private void ValidateFields()
        {
            Validator.ValidateIntRange(this.wheels, Constants.MinWheels, Constants.MaxWheels, string.Format(Constants.NumberMustBeBetweenMinAndMax, WheelsProperty, Constants.MinWheels, Constants.MaxWheels));

            Validator.ValidateNull(this.make, string.Format(Constants.PropertyCannotBeNull, MakeProperty));
            Validator.ValidateIntRange(this.make.Length, Constants.MinMakeLength, Constants.MaxMakeLength, string.Format(Constants.StringMustBeBetweenMinAndMax, MakeProperty, Constants.MinMakeLength, Constants.MaxMakeLength));

            Validator.ValidateNull(this.model, string.Format(Constants.PropertyCannotBeNull, ModelProperty));
            Validator.ValidateIntRange(this.model.Length, Constants.MinModelLength, Constants.MaxModelLength, string.Format(Constants.StringMustBeBetweenMinAndMax, ModelProperty, Constants.MinModelLength, Constants.MaxModelLength));

            Validator.ValidateDecimalRange(this.price, Constants.MinPrice, Constants.MaxPrice, string.Format(Constants.NumberMustBeBetweenMinAndMax, PriceProperty, Constants.MinPrice, Constants.MaxPrice));
        }
    }
}
