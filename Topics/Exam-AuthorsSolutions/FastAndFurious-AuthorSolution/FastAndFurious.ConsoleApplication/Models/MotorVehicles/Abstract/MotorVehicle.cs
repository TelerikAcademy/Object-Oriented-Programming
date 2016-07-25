using System;
using System.Collections.Generic;
using System.Linq;
using FastAndFurious.ConsoleApplication.Common.Constants;
using FastAndFurious.ConsoleApplication.Common.Exceptions;
using FastAndFurious.ConsoleApplication.Common.Utils;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Common;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract
{
    public abstract class MotorVehicle : IdentifiableObject, IMotorVehicle, IWeightable, IValuable, IIdentifiable
    {
        private readonly int weight;
        private readonly int topSpeed;
        private readonly int acceleration;
        private readonly decimal price;
        private readonly ICollection<ITunningPart> tunningParts;

        public MotorVehicle(
            decimal price,
            int weight,
            int topSpeed,
            int acceleration)
            : base()
        {
            this.price = price;
            this.weight = weight;
            this.acceleration = acceleration;
            this.topSpeed = topSpeed;
            this.tunningParts = new List<ITunningPart>();
        }

        public decimal Price
        {
            get
            {
                return this.Price + this.TunningParts.Sum(x => x.Price);
            }
        }

        public int Weight
        {
            get
            {
                return this.weight + this.TunningParts.Sum(x => x.Weight);
            }
        }

        public int Acceleration
        {
            get
            {
                return this.acceleration + this.TunningParts.Sum(x => x.Acceleration);
            }
        }

        public int TopSpeed
        {
            get
            {
                return this.topSpeed + this.TunningParts.Sum(x => x.TopSpeed);
            }
        }

        public IEnumerable<ITunningPart> TunningParts
        {
            get
            {
                return this.tunningParts;
            }
        }

        public void AddTunning(ITunningPart part)
        {
            if (this.TunningParts.Any(x => x.GetType().BaseType == part.GetType().BaseType))
            {
                var message = GlobalConstants.CannotAddMultiplePartsOfTheSameTypeToVehicleExceptionMessage;
                var parameter = part.GetType().Name;
                throw new TunningDuplicationException(message, parameter);
            }

            this.tunningParts.Add(part);
        }

        public bool RemoveTunning(ITunningPart part)
        {
            return this.tunningParts.Remove(part);
        }

        public TimeSpan Race(int trackLengthInMeters)
        {
            var topSpeedInMetersPerSecond = MetricUnitsConverter.GetMetersPerSecondFrom(this.TopSpeed);
            var accelerationInMetersPerSecondSquared = this.Acceleration;

            var timeRequiredToReachTopSpeedInSeconds = (topSpeedInMetersPerSecond / accelerationInMetersPerSecondSquared);
            var distanceTravelledWhileReachingTopSpeedInMeters = accelerationInMetersPerSecondSquared * Math.Pow(timeRequiredToReachTopSpeedInSeconds, 2);

            if (trackLengthInMeters == distanceTravelledWhileReachingTopSpeedInMeters)
            {
                return TimeSpan.FromSeconds(timeRequiredToReachTopSpeedInSeconds);
            }
            else if (trackLengthInMeters > distanceTravelledWhileReachingTopSpeedInMeters)
            {
                var remainingDistanceInMeters = trackLengthInMeters - distanceTravelledWhileReachingTopSpeedInMeters;
                var timeRequiredToTravelRemainingDistanceInSeconds = remainingDistanceInMeters / topSpeedInMetersPerSecond;
                var totalTimeInSeconds = timeRequiredToReachTopSpeedInSeconds + timeRequiredToTravelRemainingDistanceInSeconds;

                return TimeSpan.FromSeconds(totalTimeInSeconds);
            }
            else
            {
                var totalTime = Math.Sqrt((trackLengthInMeters / accelerationInMetersPerSecondSquared));

                return TimeSpan.FromSeconds(totalTime);
            }
        }
    }
}
