using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{
    public class MagnaflowExhaust : Exhaust, IExhaust, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int MagnaflowExhaustWeightInGrams = 12800;
        private const int MagnaflowExhaustAccelerationBonus = 5;
        private const int MagnaflowExhaustTopSpeedBonus = 25;
        private const decimal MagnaflowExhaustPriceInUSADollars = 379;

        public MagnaflowExhaust()
            : base(
                  MagnaflowExhaustPriceInUSADollars,
                  MagnaflowExhaustWeightInGrams,
                  MagnaflowExhaustAccelerationBonus,
                  MagnaflowExhaustTopSpeedBonus,
                  TunningGradeType.LowGrade,
                  ExhaustType.NickelChromePlated)
        {
        }
    }
}
