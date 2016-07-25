using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class VinBenzin : Driver
    {
        public const string VinBenzinDriverName = "Vin Benzin";

        public VinBenzin() : base(VinBenzinDriverName, GenderType.Male)
        {
        }
    }
}
