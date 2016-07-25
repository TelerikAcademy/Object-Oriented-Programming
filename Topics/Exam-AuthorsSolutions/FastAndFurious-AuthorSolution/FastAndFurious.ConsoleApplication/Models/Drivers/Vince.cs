using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class Vince : Driver
    {
        public const string VinceDriverName = "Vince";

        public Vince() 
            : base(VinceDriverName, GenderType.Male)
        {
        }
    }
}
