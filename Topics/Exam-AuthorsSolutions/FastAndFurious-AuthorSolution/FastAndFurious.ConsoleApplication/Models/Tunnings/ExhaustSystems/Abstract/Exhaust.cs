using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems.Abstract
{
    public abstract class Exhaust : TunningPart, IExhaust, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private readonly ExhaustType exhaustType;

        public Exhaust(
           decimal price,
           int weight,
           int acceleration,
           int topSpeed,
           TunningGradeType gradeType,
           ExhaustType exhaustType)
            : base(
                  price,
                  weight,
                  acceleration,
                  topSpeed,
                  gradeType)
        {
            this.exhaustType = exhaustType;
        }

        public ExhaustType ExhaustType
        {
            get
            {
                return this.exhaustType;
            }
        }
    }
}
