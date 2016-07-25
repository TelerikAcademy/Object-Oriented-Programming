using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Tires.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Tires
{
    public class FalkenAzenisTiresSet : TiresSet, ITunningPart, ITireSet, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int FalkenAzenisTireWeightInGrams = 7800;
        private const int FalkenAzenisTireAccelerationBonus = 3;
        private const int FalkenAzenisTireTopSpeedBonus = 0;
        private const decimal FalkenAzenisTirePriceInUSADollars = 359;

        public FalkenAzenisTiresSet()
            : base(
                  FalkenAzenisTirePriceInUSADollars,
                  FalkenAzenisTireWeightInGrams,
                  FalkenAzenisTireAccelerationBonus,
                  FalkenAzenisTireTopSpeedBonus,
                  TunningGradeType.LowGrade,
                  TireType.OffRoadTire)
        {
        }
    }
}
