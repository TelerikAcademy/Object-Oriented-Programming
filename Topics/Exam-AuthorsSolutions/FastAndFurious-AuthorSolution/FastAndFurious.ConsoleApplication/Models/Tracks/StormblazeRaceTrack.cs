using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastAndFurious.ConsoleApplication.Models.Tracks.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tracks
{
    public class StormblazeRaceTrack : RaceTrack
    {
        private const string StormblazeRaceTrackName = "Stormblaze Race Track";
        private const int StormblazeRaceTrackMaxParticipantsCount = 4;
        private const int StormblazeRaceTrackMinParticipantsCount = 2;
        private const int StormblazeRaceTrackLengthInMeters = 1000;

        public StormblazeRaceTrack() 
            : base(
                  StormblazeRaceTrackName,
                  StormblazeRaceTrackMaxParticipantsCount,
                  StormblazeRaceTrackMinParticipantsCount,
                  StormblazeRaceTrackLengthInMeters)
        {
        }
    }
}
