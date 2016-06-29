namespace Societies.Core.Models.Common
{
    using Abstract;
    using Contracts;
    using Infrastructure.Enumerations.Common;

    public class Beverage : Consumable, IBeverage
    {
        public int PortionSizeInMilliliters { get; set; }

        public BeverageType Type { get; set; }
    }
}