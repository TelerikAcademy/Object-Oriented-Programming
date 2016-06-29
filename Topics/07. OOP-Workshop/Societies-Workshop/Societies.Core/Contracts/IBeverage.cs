namespace Societies.Core.Contracts
{
    using Infrastructure.Enumerations.Common;

    public interface IBeverage : IConsumable
    {
        int PortionSizeInMilliliters { get; set; }

        BeverageType Type { get; }
    }
}
