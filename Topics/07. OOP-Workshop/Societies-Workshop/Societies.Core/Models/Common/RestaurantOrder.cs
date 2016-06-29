namespace Societies.Core.Models.Common
{
    using Contracts;
    using System.Collections.Generic;
    using System.Text;

    public class RestaurantOrder : IRestaurantOrder
    {
        public ICollection<IBeverage> Beverages { get; set; }

        public ICollection<IFood> Foods { get; set; }

        public decimal TotalOrderPrice
        {
            get
            {
                var totalOrderPrice = 0m;

                foreach(var food in this.Foods)
                {
                    totalOrderPrice += food.TotalPrice;
                }

                foreach (var beverage in this.Beverages)
                {
                    totalOrderPrice += beverage.TotalPrice;
                }

                return totalOrderPrice;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder(300);

            foreach(var food in this.Foods)
            {
                builder.AppendLine($"Food type: {food.Type}");
                builder.AppendLine($"Portion size: {food.PortionSizeInGrams} gr");
                builder.AppendLine($"Price: ${food.TotalPrice}");
            }

            foreach (var beverage in this.Beverages)
            {
                builder.AppendLine($"Food type: {beverage.Type}");
                builder.AppendLine($"Portion size: {beverage.PortionSizeInMilliliters} ml");
                builder.AppendLine($"Price: ${beverage.TotalPrice}");
            }

            return builder.ToString();
        }
    }
}