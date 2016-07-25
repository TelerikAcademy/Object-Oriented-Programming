using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastAndFurious.ConsoleApplication.Models.Tracks.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tracks
{
    public class IndianapolisRaceTrack : RaceTrack
    {
        private const string IndianapolisRaceTrackName = "Indianapolis Race Track";
        private const int IndianapolisRaceTrackMaxParticipantsCount = 7;
        private const int IndianapolisRaceTrackMinParticipantsCount = 2;
        private const int IndianapolisRaceTrackTrackLengthInMeters = 12000;

        public IndianapolisRaceTrack() 
            : base(
                  IndianapolisRaceTrackName,
                  IndianapolisRaceTrackMaxParticipantsCount,
                  IndianapolisRaceTrackMinParticipantsCount,
                  IndianapolisRaceTrackTrackLengthInMeters)
        {
        }
    }
}
