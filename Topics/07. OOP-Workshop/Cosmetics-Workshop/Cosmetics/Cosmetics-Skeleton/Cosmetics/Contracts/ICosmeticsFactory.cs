namespace Cosmetics.Contracts
{
    using System.Collections.Generic;

    using Cosmetics.Common;
    using Cart;
    using Products;
	
    public interface ICosmeticsFactory
    {
        ICategory CreateCategory(string name);

        Shampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage);

        IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients);

        ShoppingCart ShoppingCart();
    }
}
