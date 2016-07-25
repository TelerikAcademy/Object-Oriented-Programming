using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers
{
    public class VortexR35SequentialTurbocharger : Turbocharger, ITurbocharger
    {
        private const int VortexR35SequentialTurbochargerWeightInGrams = 3900;
        private const int VortexR35SequentialTurbochargerAccelerationBonus = 10;
        private const int VortexR35SequentialTurbochargerTopSpeedBonus = 85;
        private const decimal VortexR35SequentialTurbochargerPriceInUSADollars = 699;

        public VortexR35SequentialTurbocharger()
            : base(
                  VortexR35SequentialTurbochargerPriceInUSADollars,
                  VortexR35SequentialTurbochargerWeightInGrams,
                  VortexR35SequentialTurbochargerAccelerationBonus,
                  VortexR35SequentialTurbochargerTopSpeedBonus,
                  TunningGradeType.HighGrade,
                  TurbochargerType.SequentialTurbo)
        {
        }
    }
}
