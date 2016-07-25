using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Motors.Abstract
{
    public abstract class Motor : TunningPart, IMotor, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private readonly int horsepower;
        private readonly MotorType engineType;
        private readonly CylinderType cylinderType;

        public Motor(
            decimal price,
            int weight,
            int acceleration,
            int topSpeed,
            int horsepower,
            TunningGradeType gradeType,
            CylinderType cylinderType,
            MotorType engineType)
            : base(
                  price,
                  weight,
                  acceleration,
                  topSpeed,
                  gradeType)
        {
            this.horsepower = horsepower;
            this.cylinderType = cylinderType;
            this.engineType = engineType;
        }

        public int Horsepower
        {
            get { return this.horsepower; }
        }

        public MotorType EngineType
        {
            get
            {
                return this.engineType;
            }
        }

        public CylinderType CylinderType
        {
            get
            {
                return this.cylinderType;
            }
        }
    }
}
