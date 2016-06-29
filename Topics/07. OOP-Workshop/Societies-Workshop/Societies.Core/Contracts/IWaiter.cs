namespace Societies.Core.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IWaiter : IHuman
    {
        bool IsAvailable { get; }
        decimal Bakshishes { get; }
        decimal RestaurantProfits { get; }

        void GetOrder(IRestaurantOrder order, IHuman client);
        void ServeOrder(IHuman client);
        void RequestPayment(IHuman client);
    }
}