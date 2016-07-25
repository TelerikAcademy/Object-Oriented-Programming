using FastAndFurious.ConsoleApplication.Common.Enums;

namespace FastAndFurious.ConsoleApplication.Contracts
{
    public interface IMotor : ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        int Horsepower { get; }

        MotorType EngineType { get; }

        CylinderType CylinderType { get; }
    }
}
