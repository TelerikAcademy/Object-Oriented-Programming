using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    public class NissanGTR : MotorVehicle
    {
        private const int NissanGTRWeightInGrams = 1850000;
        private const int NissanGTRAcceleration = 45;
        private const int NissanGTRTopSpeed = 300;
        private const decimal NissanGTRPriceInUSADollars = 125000;

        public NissanGTR() 
            : base(
                  NissanGTRPriceInUSADollars,
                  NissanGTRWeightInGrams,
                  NissanGTRTopSpeed,
                  NissanGTRAcceleration)
        {
        }
    }
}
