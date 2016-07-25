using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.EngineControlUnits.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.EngineControlUnits
{
    public class APREngineControlUnit : EngineControlUnit, IEngineControlUnit, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int APREngineControlUnitWeightInGrams = 22000;
        private const int APREngineControlUnitAccelerationBonus = 45;
        private const int APREngineControlUnitTopSpeedBonus = 75;
        private const decimal APREngineControlUnitPriceInUSADollars = 5789;

        public APREngineControlUnit()
            : base(
                  APREngineControlUnitPriceInUSADollars,
                  APREngineControlUnitWeightInGrams,
                  APREngineControlUnitAccelerationBonus,
                  APREngineControlUnitTopSpeedBonus,
                  TunningGradeType.HighGrade,
                  EngineControlUnitType.Pro)
        {
        }
    }
}
