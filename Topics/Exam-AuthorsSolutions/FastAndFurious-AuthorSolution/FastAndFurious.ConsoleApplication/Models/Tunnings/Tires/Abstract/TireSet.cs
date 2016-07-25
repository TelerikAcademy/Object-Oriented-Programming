using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Tires.Abstract
{
    public abstract class TiresSet : TunningPart, ITunningPart, ITireSet, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private readonly TireType tireType;

        public TiresSet(
            decimal price, 
            int weight, 
            int acceleration, 
            int topSpeed, 
            TunningGradeType gradeType,
            TireType tireType) 
            : base(
                  price, 
                  weight, 
                  acceleration, 
                  topSpeed, 
                  gradeType)
        {
        }

        public TireType TireType
        {
            get
            {
                return this.tireType;
            }
        }
    }
}
