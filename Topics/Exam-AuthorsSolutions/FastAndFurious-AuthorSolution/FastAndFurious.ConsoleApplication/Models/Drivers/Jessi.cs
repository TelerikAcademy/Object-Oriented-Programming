using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class Jessi : Driver
    {
        private const string JessiDriverName = "Jessi";

        public Jessi() 
            : base(JessiDriverName, GenderType.Female)
        {
        }
    }
}
