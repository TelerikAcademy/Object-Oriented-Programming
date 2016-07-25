using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers
{
    public class ZX8ParallelTwinTurbocharger : Turbocharger, ITurbocharger, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int ZX8ParallelTwinTurbochargerWeightInGrams = 3500;
        private const int ZX8ParallelTwinTurbochargerAccelerationBonus = 15;
        private const int ZX8ParallelTwinTurbochargerTopSpeedBonus = 60;
        private const decimal ZX8ParallelTwinTurbochargerPriceInUSADollars = 799;

        public ZX8ParallelTwinTurbocharger()
            : base(
                  ZX8ParallelTwinTurbochargerPriceInUSADollars,
                  ZX8ParallelTwinTurbochargerWeightInGrams,
                  ZX8ParallelTwinTurbochargerAccelerationBonus,
                  ZX8ParallelTwinTurbochargerTopSpeedBonus,
                  TunningGradeType.HighGrade,
                  TurbochargerType.TwinTurbo)
        {
        }
    }
}
