using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastAndFurious.ConsoleApplication.Models.Tracks.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tracks
{
    public class MonacoRaceTrack : RaceTrack
    {
        private const string MonacoRaceTrackName = "Monaco Race Track";
        private const int MonacoRaceTrackMaxParticipantsCount = 5;
        private const int MonacoRaceTrackMinParticipantsCount = 2;
        private const int MonacoRaceTrackTrackLengthInMeters = 2000;

        public MonacoRaceTrack() 
            : base(
                  MonacoRaceTrackName,
                  MonacoRaceTrackMaxParticipantsCount,
                  MonacoRaceTrackMinParticipantsCount,
                  MonacoRaceTrackTrackLengthInMeters)
        {
        }
    }
}
