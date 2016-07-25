using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Transmissions.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Transmissions
{
    public class BMShortShifter : Transmission, ITransmission, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int BMShortShifterWeightInGrams = 5700;
        private const int BMShortShifterAccelerationBonus = 28;
        private const int BMShortShifterTopSpeedBonus = 0;
        private const decimal BMShortShifterPriceInUSADollars = 2799;

        public BMShortShifter() 
            : base(
                  BMShortShifterPriceInUSADollars,
                  BMShortShifterWeightInGrams,
                  BMShortShifterAccelerationBonus,
                  BMShortShifterTopSpeedBonus, 
                  TunningGradeType.HighGrade, 
                  TransmissionType.ManualShortShifter)
        {
        }
    }
}
