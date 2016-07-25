using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Transmissions.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Transmissions
{
    public class TWMPerformanceTransmission : Transmission, ITransmission, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int TWMPerformanceTransmissionWeightInGrams = 4799;
        private const int TWMPerformanceTransmissionAccelerationBonus = 15;
        private const int TWMPerformanceTransmissionTopSpeedBonus = 0;
        private const decimal TWMPerformanceTransmissionPriceInUSADollars = 1599;

        public TWMPerformanceTransmission() 
            : base(
                  TWMPerformanceTransmissionPriceInUSADollars,
                  TWMPerformanceTransmissionWeightInGrams,
                  TWMPerformanceTransmissionAccelerationBonus,
                  TWMPerformanceTransmissionTopSpeedBonus, 
                  TunningGradeType.LowGrade, 
                  TransmissionType.SemiManualShifter)
        {
        }
    }
}
