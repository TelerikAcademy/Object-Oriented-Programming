using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Motors.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Motors
{
    public class IronHorseMotor : Motor, IMotor, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int IronHorseMotorWeightInGrams = 180000;
        private const int IronHorseMotorAccelerationBonus = 70;
        private const int IronHorseMotorTopSpeedBonus = 130;
        private const int IronHorseMotorHorsepower = 350;
        private const decimal IronHorseMotorPriceInUSADollars = 6399;

        public IronHorseMotor()
            : base(
                  IronHorseMotorPriceInUSADollars,
                  IronHorseMotorWeightInGrams,
                  IronHorseMotorAccelerationBonus,
                  IronHorseMotorTopSpeedBonus,
                  IronHorseMotorHorsepower,
                  TunningGradeType.MidGrade,
                  CylinderType.V8,
                  MotorType.SteamMotor)
        {
        }
    }
}
