using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Motors.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Motors
{
    public class ShockblazePulsejetMotor : Motor, IMotor, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int ShockblazePulsejetMotorWeightInGrams = 150000;
        private const int ShockblazePulsejetMotorAccelerationBonus = 80;
        private const int ShockblazePulsejetMotorTopSpeedBonus = 220;
        private const int ShockblazePulsejetMotorHorsepower = 700;
        private const decimal ShockblazePulsejetMotorPriceInUSADollars = 12899;

        public ShockblazePulsejetMotor()
            : base(
                  ShockblazePulsejetMotorPriceInUSADollars,
                  ShockblazePulsejetMotorWeightInGrams,
                  ShockblazePulsejetMotorAccelerationBonus,
                  ShockblazePulsejetMotorTopSpeedBonus,
                  ShockblazePulsejetMotorHorsepower,
                  TunningGradeType.HighGrade,
                  CylinderType.V16,
                  MotorType.PulseJet)
        {
        }
    }
}
