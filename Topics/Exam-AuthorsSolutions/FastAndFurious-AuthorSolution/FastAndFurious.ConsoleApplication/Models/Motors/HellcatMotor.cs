using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Motors.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Motors
{
    public class HellcatMotor : Motor, IMotor, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int HellcatMotorWeightInGrams = 145000;
        private const int HellcatMotorAccelerationBonus = 75;
        private const int HellcatMotorTopSpeedBonus = 250;
        private const int HellcatMotorHorsepower = 760;
        private const decimal HellcatMotorPriceInUSADollars = 14599;

        public HellcatMotor()
            : base(
                  HellcatMotorPriceInUSADollars,
                  HellcatMotorWeightInGrams,
                  HellcatMotorAccelerationBonus,
                  HellcatMotorTopSpeedBonus,
                  HellcatMotorHorsepower,
                  TunningGradeType.HighGrade,
                  CylinderType.V16,
                  MotorType.SabreReactionMotor)
        {
        }
    }
}
