using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers.Abstract
{
    public abstract class Turbocharger : TunningPart, ITurbocharger, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private readonly TurbochargerType turbochargerType;

        public Turbocharger(
            decimal price,
            int weight,
            int acceleration,
            int topSpeed,
            TunningGradeType grade,
            TurbochargerType turbochargerType)
            : base(
                  price,
                  weight,
                  acceleration,
                  topSpeed,
                  grade)
        {
            this.turbochargerType = turbochargerType;
        }

        public TurbochargerType TurbochargerType
        {
            get
            {
                return this.turbochargerType;
            }
        }
    }
}
