using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.EngineControlUnits.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.EngineControlUnits
{
    public class DinanEngineControlUnit : EngineControlUnit, IEngineControlUnit, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int DinanEngineControlUnitWeightInGrams = 19000;
        private const int DinanEngineControlUnitAccelerationBonus = 35;
        private const int DinanEngineControlUnitTopSpeedBonus = 65;
        private const decimal DinanEngineControlUnitPriceInUSADollars = 4999;

        public DinanEngineControlUnit()
            : base(
                  DinanEngineControlUnitPriceInUSADollars,
                  DinanEngineControlUnitWeightInGrams,
                  DinanEngineControlUnitAccelerationBonus,
                  DinanEngineControlUnitTopSpeedBonus,
                  TunningGradeType.MidGrade,
                  EngineControlUnitType.Performance)
        {
        }
    }
}
