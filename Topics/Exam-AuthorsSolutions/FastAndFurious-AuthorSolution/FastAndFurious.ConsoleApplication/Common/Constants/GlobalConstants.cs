namespace FastAndFurious.ConsoleApplication.Common.Constants
{
    public class GlobalConstants
    {
        public const string DriverCannotBeSignedForRaceTrackParticipantMoreThanOnceExceptionMessage = "Cannot sign the same participant to a track";
        public const string DriverCannotBeAssignedAsOwnerToVehicleMoreThanOnceExceptionMessage = "A driver cannot be assigned as owner to a specific vehicle more than once.";
        public const string CannotAddMultiplePartsOfTheSameTypeToVehicleExceptionMessage = "Cannot add multiple parts of the same type to a vehicle";
        public const string CannotSetNullObjectAsActiveVehicleExceptionMessage = "Cannot set a null object as an active vehicle.";
        public const string CannotSetForeignVehicleAsActiveExceptionMessage = "Cannot set a foreign vehicle as your active vehicle.";
        public const string RemovalOperationNotSupportedExceptionMessage = "Removal operation not supported";
        public const string CreationalOperationNotSupportedExceptionMessage = "Creational operation not supported";
        public const string AssigningOperationNotSupportedExceptionMessage = "Assigning operation not supported";

        public const string CreationStrategyCommand = "-create";
        public const string RemovalStrategyCommand = "-remove";
        public const string AssigningStrategyCommand = "-assign";
        public const string SelectingStrategyCommand = "-select";
        public const string DisplayingStrategyCommand = "-display";
        public const string RunningStrategyCommand = "-run";
        public const string VehicleCommand = "-vehicle";
        public const string DriverCommand = "-driver";
        public const string TunningCommand = "-tunning";
        public const string TrackCommand = "-track";
        public const string ExitCommand = "-exit";

        public const string PerformingRaceOnTrackMessage = "Performing drag race on track \"{0}\" with {1} participants.";
        public const string CannotStartRaceMessage = "Cannot start the race with {0} participants only.";
        public const string DisplayBestNTimesEverMessage = "Best {0} times ever for track \"{1}\":";
        public const string DriverSelectsNewVehicleMessage = "{0} now drives {1} {2}";
        public const string ItemAssignedSuccessfullyMessage = "Item with ID:{0} assigned successfully!";
        public const string NoRacesYetMessage = "No races yet for {0}";
        public const string CannotAddMoreParticipantsToRaceTrack = "Cannot add more participants to the Race Track";

        public const bool ThrowOnError = true;
        public const bool IgnoreCase = true;
    }
}
