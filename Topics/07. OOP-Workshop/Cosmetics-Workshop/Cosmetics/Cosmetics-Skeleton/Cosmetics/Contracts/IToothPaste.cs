namespace Cosmetics.Contracts
{
    using System.Collections.Generic;

    public interface IToothpaste : IProduct
    {
        string Ingredients { get; }
    }
}