namespace Societies.Core.Contracts
{
    public interface IBuilding : INameable
    {
        string Address { get; }

        // TODO: Configurable
        int Capacity { get; }
    }
}
