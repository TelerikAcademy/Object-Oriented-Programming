using System;
using System.Collections.Generic;

namespace FastAndFurious.ConsoleApplication.Contracts
{
    public interface IMotorVehicle : IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        /// <summary>
        /// Collects all of the tunning parts applied to the vehicle.
        /// (Intercoolers, Turbochargers, Exhaust systems, Transmissions, Tires, Engine control units, etc...)
        /// </summary>
        IEnumerable<ITunningPart> TunningParts { get; }

        /// <summary>
        /// Calculates the time required to finish a race given the track length in meters.
        /// Returns the time required to finish a race.
        /// </summary>
        /// <param name="trackLengthInMeters">
        /// The track length in meters.
        /// </param>
        /// <returns>
        /// Returns the time required to finish a race.
        /// </returns>
        TimeSpan Race(int trackLengthInMeters);

        /// <summary>
        /// Applies tunning parts to the vehicle.
        /// </summary>
        /// <param name="part">
        /// The tunning part to be applied.
        /// </param>
        void AddTunning(ITunningPart part);

        /// <summary>
        /// Removes the specified tunning part from the vehicle's systems.
        /// </summary>
        /// <returns>
        /// Returns "true" if the part was successfully removed.
        /// Or "false" if the removal failed.
        /// </returns>
        bool RemoveTunning(ITunningPart part);
    }
}
