namespace Societies.Core.Contracts
{
    using System.Collections.Generic;

    public interface IRestaurantOrder
    {
        ICollection<IFood> Foods { get; set; }
        ICollection<IBeverage> Beverages { get; set; }
        decimal TotalOrderPrice { get; }
    }
}
