using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class DominicRendeto : Driver
    {
        private const string DominicRendetoDriverName = "Dominic Rendeto";

        public DominicRendeto() 
            : base(DominicRendetoDriverName, GenderType.Male)
        {
        }
    }
}
