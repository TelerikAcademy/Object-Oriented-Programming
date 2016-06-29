namespace Societies.Core.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IRestaurantBuilding : IBuilding
    {
        ICollection<IHuman> Clients { get; }
        ICollection<IWaiter> Waiters { get; }

        void AcceptClient(IHuman human);
        void SendClientHome(IHuman human);

        void HireWaiter(IWaiter waiter);
        void FireWaiter(IWaiter waiter);

        void ProcessClientRequests();
    }
}
