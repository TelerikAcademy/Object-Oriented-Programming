using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Motors.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Motors
{
    public class CentaurPulseMotor : Motor, IMotor, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int CentaurPulseMotorWeightInGrams = 175000;
        private const int CentaurPulseMotorAccelerationBonus = 50;
        private const int CentaurPulseMotorTopSpeedBonus = 180;
        private const int CentaurPulseMotorHorsepower = 480;
        private const decimal CentaurPulseMotorPriceInUSADollars = 5999;

        public CentaurPulseMotor()
            : base(
                  CentaurPulseMotorPriceInUSADollars,
                  CentaurPulseMotorWeightInGrams,
                  CentaurPulseMotorAccelerationBonus,
                  CentaurPulseMotorTopSpeedBonus,
                  CentaurPulseMotorHorsepower,
                  TunningGradeType.MidGrade,
                  CylinderType.V6,
                  MotorType.PulseDetonationMotor)
        {
        }
    }
}
