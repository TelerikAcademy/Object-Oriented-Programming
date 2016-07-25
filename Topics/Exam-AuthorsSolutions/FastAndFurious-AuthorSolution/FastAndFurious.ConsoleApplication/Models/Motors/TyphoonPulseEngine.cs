using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Motors.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Motors
{
    public class TyphoonPulseMotor : Motor, IMotor, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int TyphoonPulseMotorWeightInGrams = 176000;
        private const int TyphoonPulseMotorAccelerationBonus = 90;
        private const int TyphoonPulseMotorTopSpeedBonus = 300;
        private const int TyphoonPulseMotorHorsepower = 1200;
        private const decimal TyphoonPulseMotorPriceInUSADollars = 15999;

        public TyphoonPulseMotor()
            : base(
                  TyphoonPulseMotorPriceInUSADollars,
                  TyphoonPulseMotorWeightInGrams,
                  TyphoonPulseMotorAccelerationBonus,
                  TyphoonPulseMotorTopSpeedBonus,
                  TyphoonPulseMotorHorsepower,
                  TunningGradeType.HighGrade,
                  CylinderType.V16,
                  MotorType.PulseDetonationMotor)
        {
        }
    }
}
