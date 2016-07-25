using FastAndFurious.ConsoleApplication.Common.Enums;

namespace FastAndFurious.ConsoleApplication.Contracts
{
    public interface IEngineControlUnit : ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        EngineControlUnitType EngineControlUnitType { get; }
    }
}
