using FastAndFurious.ConsoleApplication.Common.Enums;

namespace FastAndFurious.ConsoleApplication.Contracts
{
    public interface ITunningPart : IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        TunningGradeType GradeType { get; }
    }
}
