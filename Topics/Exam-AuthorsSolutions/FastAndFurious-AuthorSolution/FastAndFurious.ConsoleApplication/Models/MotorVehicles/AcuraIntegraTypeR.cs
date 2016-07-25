using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    public class AcuraIntegraTypeR : MotorVehicle
    {
        private const int AcuraIntegraTypeRWeightInGrams = 1700000;
        private const int AcuraIntegraTypeRAcceleration = 15;
        private const int AcuraIntegraTypeRTopSpeed = 200;
        private const decimal AcuraIntegraTypeRPriceInUSADollars = 24999;

        public AcuraIntegraTypeR() 
            : base(
                  AcuraIntegraTypeRPriceInUSADollars,
                  AcuraIntegraTypeRWeightInGrams,
                  AcuraIntegraTypeRTopSpeed,
                  AcuraIntegraTypeRAcceleration)
        {
        }
    }
}
