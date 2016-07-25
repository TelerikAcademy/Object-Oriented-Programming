using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System.Text;

namespace Dealership.Models
{
    public class Motorcycle : Vehicle, IMotorcycle
    {
        private const string CategoryProperty = "Category";

        private readonly string category;

        public Motorcycle(string make, string model, decimal price, string category)
            : base(make, model, price, VehicleType.Motorcycle)
        {
            this.category = category;

            this.ValidateFields();
        }

        public string Category
        {
            get
            {
                return this.category;
            }
        }

        protected override string PrintAdditionalInfo()
        {
            return string.Format("  {0}: {1}", CategoryProperty, this.Category);
        }

        private void ValidateFields()
        {
            Validator.ValidateNull(this.category, string.Format(Constants.PropertyCannotBeNull, CategoryProperty));
            Validator.ValidateIntRange(this.category.Length, Constants.MinCategoryLength, Constants.MaxCategoryLength, string.Format(Constants.StringMustBeBetweenMinAndMax, CategoryProperty, Constants.MinCategoryLength, Constants.MaxCategoryLength));
        }
    }
}
