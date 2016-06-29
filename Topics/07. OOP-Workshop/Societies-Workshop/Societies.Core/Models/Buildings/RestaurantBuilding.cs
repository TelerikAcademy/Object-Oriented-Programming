namespace Societies.Core.Models.Buildings
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using Abstract;
    using Common;
    using Contracts;
    using Infrastructure.Enumerations.Common;
    using Infrastructure.Utils;

    [Serializable]
    public class RestaurantBuilding : Building, IRestaurantBuilding
    {
        private ICollection<IHuman> clients;
        private ICollection<IWaiter> waiters;

        public RestaurantBuilding(
            string name,
            string address,
            int capacity)
            : base(name, address, capacity)
        {
            this.waiters = new List<IWaiter>();
            this.clients = new List<IHuman>();
        }

        public ICollection<IHuman> Clients
        {
            get
            {
                var clientsCollectionCopy = Cloner.DeepClone<ICollection<IHuman>>(this.clients);
                return clientsCollectionCopy;
            }
        }

        public ICollection<IWaiter> Waiters
        {
            get
            {
                var waitersCollectionCopy = Cloner.DeepClone<ICollection<IWaiter>>(this.waiters);
                return waitersCollectionCopy;
            }
        }

        public void AcceptClient(IHuman human)
        {
            if (human.Age < 14)
            {
                throw new ArgumentException("Too young to eat");
            }

            if (this.clients != null &&
                this.clients.Count < this.Capacity)
            {
                this.clients.Add(human);
            }
            else
            {
                throw new IndexOutOfRangeException("Nqma mqsto");
            }
        }

        public void SendClientHome(IHuman human)
        {
            if (this.clients != null && this.clients.Count > 0)
            {
                this.clients.Remove(human);
            }
        }

        public void FireWaiter(IWaiter waiter)
        {
            if (this.waiters != null &&
                this.waiters.Count > 0)
            {
                this.waiters.Remove(waiter);
            }
        }

        public void HireWaiter(IWaiter waiter)
        {
            if (waiter.Age < 18 || waiter.Age > 65)
            {
                throw new ArgumentOutOfRangeException("Ne mojem da naemame hora pod 18 godini i hora nad 65 godini.");
            }

            this.waiters.Add(waiter);
        }

        public void ProcessClientRequests()
        {
            foreach(var client in this.clients)
            {
                var waiter = this.waiters.FirstOrDefault(x => x.IsAvailable);
                if(waiter == null)
                {
                    throw new KeyNotFoundException("No waiters available");
                }

                // TODO: Extract the order generation in the client or in a DataGenerator class
                var order = new RestaurantOrder
                {
                    Beverages = new Collection<IBeverage>
                    {
                        new Beverage
                        {
                            PortionSizeInMilliliters = 250,
                            TotalPrice = 10,
                            Type = BeverageType.Beer
                        },
                        new Beverage
                        {
                            PortionSizeInMilliliters = 300,
                            TotalPrice = 2,
                            Type = BeverageType.WellWater
                        }
                    },
                    Foods = new Collection<IFood> {
                        new Food
                        {
                            PortionSizeInGrams = 500,
                            TotalPrice = 3,
                            Type = FoodType.FruitSalad
                        },
                        new Food
                        {
                            PortionSizeInGrams = 450,
                            TotalPrice = 5,
                            Type = FoodType.VegetablesSalad
                        }
                    }
                };

                waiter.GetOrder(order, client);
                waiter.ServeOrder(client);
                waiter.RequestPayment(client);
            }
        }
    }
}