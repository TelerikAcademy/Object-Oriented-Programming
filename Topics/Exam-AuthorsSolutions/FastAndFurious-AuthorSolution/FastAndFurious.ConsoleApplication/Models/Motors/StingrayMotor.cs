using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Motors.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Motors
{
    public class StingrayMotor : Motor, IMotor, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int StingrayMotorWeightInGrams = 158000;
        private const int StingrayMotorAccelerationBonus = 60;
        private const int StingrayMotorTopSpeedBonus = 230;
        private const int StingrayMotorHorsepower = 800;
        private const decimal StingrayMotorPriceInUSADollars = 10899;

        public StingrayMotor()
            : base(
                  StingrayMotorPriceInUSADollars,
                  StingrayMotorWeightInGrams,
                  StingrayMotorAccelerationBonus,
                  StingrayMotorTopSpeedBonus,
                  StingrayMotorHorsepower,
                  TunningGradeType.HighGrade,
                  CylinderType.V12,
                  MotorType.ReciprocatingMotor)
        {
        }
    }
}
