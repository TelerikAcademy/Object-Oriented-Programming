namespace Cosmetics.Engine
{
    using System.Collections.Generic;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using Cosmetics.Products;
    using Cart;
	
    public class CosmeticsFactory : ICosmeticsFactory
    {
        public ICategory CreateCategory(string name)
        {
            // TODO: create category
        }

        public Shampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {
            // TODO: create shampoo
        }

        public IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
        {
            // TODO: create toothpaste
        }

        public ShoppingCart ShoppingCart()
        {
            // TODO: create shopping cart
        }
    }
}
