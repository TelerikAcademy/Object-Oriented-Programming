using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Shampoo : IShampoo, IProduct
    {
        private decimal price;
        private string name;
        private string brand;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
            this.Milliliters = milliliters;
            this.Usage = usage;

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            protected set
            {

                this.brand = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {

                this.price = value;
            }
        }

        public GenderType Gender { get; set; }

        public uint Milliliters { get; set; }

        public UsageType Usage { get; set; }

        public string Print()
        {
            throw new NotImplementedException();
        }
    }
}
