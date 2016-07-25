using System;
using System.Collections.Generic;

namespace FastAndFurious.ConsoleApplication.Contracts
{
    public interface IRaceTrack : IIdentifiable
    {
        int TrackLengthInMeters { get; }

        int MaxParticipantsCount { get; }

        int MinParticipantsCount { get; }

        string TrackName { get; }

        IEnumerable<IDriver> Participants { get; }

        IEnumerable<IEnumerable<TimeSpan>> FinishedRacesResults { get; }

        void AddParticipant(IDriver participant);

        bool RemoveParticipant(IDriver participant);

        void RunRace();
    }
}
