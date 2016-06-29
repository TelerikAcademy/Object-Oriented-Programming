namespace Societies.Core.Models.Humans
{
    using Abstract;
    using System;
    using System.Collections.Generic;
    using Infrastructure.Enumerations.Human;
    using Contracts;
    using Infrastructure.Utils;
    using Infrastructure.Constants;

    [Serializable]
    public class Waiter : Human, IWaiter
    {
        private decimal bakshishes;
        private decimal restaurantProfits;
        private bool isAvailable;

        private Dictionary<IHuman, IRestaurantOrder> orders;

        public Waiter(
            string name, 
            int age, 
            HairColorType hairColor, 
            EyesColorType eyesColor, 
            FaceShapeType faceShape, 
            RaceType race, 
            GenderType gender, 
            ReligionType religion) 
            : base(name, age, hairColor, eyesColor, faceShape, race, gender, religion)
        {
            this.isAvailable = true;
            this.orders = new Dictionary<IHuman, IRestaurantOrder>();
        }

        public decimal Bakshishes
        {
            get
            {
                return this.bakshishes;
            }
            set
            {
                this.bakshishes = value;
            }
        }
        public decimal RestaurantProfits
        {
            get
            {
                return this.restaurantProfits;
            }
        }
        public bool IsAvailable
        {
            get
            {
                return this.isAvailable;
            }
        }

        public void GetOrder(IRestaurantOrder order, IHuman client)
        {
            // I am already serving dinner
            this.isAvailable = false;

            Console.WriteLine(new string('=', GlobalConstants.DelimitersCount));
            Console.WriteLine($"Waiter({this.Name}): - \"Waiting for client order...\"");
            Console.WriteLine($"Client({client.Name}): - \"Ordering foods and beverages...\"");

            this.orders.Add(client, order);
        }
        public void ServeOrder(IHuman client)
        {
            var clientOrder = this.orders[client];

            Console.WriteLine(new string('=', GlobalConstants.DelimitersCount));
            Console.WriteLine($"Waiter({this.Name}): - \"Serving order to client ({client.Name})...\"");
            Console.WriteLine("Order details:");
            Console.WriteLine(clientOrder);

            client.Eat(clientOrder.Foods);
            client.Drink(clientOrder.Beverages);
        }
        public void RequestPayment(IHuman client)
        {
            var clientOrder = this.orders[client];
            var clientPayment = client.Pay(clientOrder.TotalOrderPrice);

            Console.WriteLine(new string('=', GlobalConstants.DelimitersCount));
            Console.WriteLine($"Payment made from: {client.Name}");
            Console.WriteLine($"Required payment amount: ${clientOrder.TotalOrderPrice}");
            Console.WriteLine($"Client payment amount: ${clientPayment}");

            if (clientPayment > clientOrder.TotalOrderPrice)
            {
                this.bakshishes += (clientPayment - clientOrder.TotalOrderPrice);
                this.restaurantProfits += clientOrder.TotalOrderPrice;
            }

            this.isAvailable = true;
        }
    }
}