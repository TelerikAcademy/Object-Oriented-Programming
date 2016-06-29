namespace Societies.Core.Contracts
{
    using Infrastructure.Enumerations.Common;

    public interface IConsumable
    {
        decimal TotalPrice { get; set; }
    }
}
