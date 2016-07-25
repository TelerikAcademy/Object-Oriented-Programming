using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Intercoolers.Abstract
{
    public abstract class Intercooler : TunningPart, IIntercooler, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private readonly IntercoolerType intercoolerType;

        public Intercooler(
            decimal price,
            int weight, 
            int acceleration,
            int topSpeed,
            TunningGradeType gradeType,
            IntercoolerType intercoolerType)
            : base(
                  price, 
                  weight, 
                  acceleration, 
                  topSpeed, 
                  gradeType)
        {
            this.intercoolerType = intercoolerType;
        }

        public IntercoolerType IntercoolerType
        {
            get
            {
                return this.intercoolerType;
            }
        }
    }
}
