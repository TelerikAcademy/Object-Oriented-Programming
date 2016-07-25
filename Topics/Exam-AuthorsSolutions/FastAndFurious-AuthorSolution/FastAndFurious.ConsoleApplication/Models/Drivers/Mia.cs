using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class Mia : Driver
    {
        private const string MiaRendetoDriverName = "Mia";

        public Mia() 
            : base(MiaRendetoDriverName, GenderType.Female)
        {
        }
    }
}
