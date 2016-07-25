using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    public class SubaruImprezaWRX : MotorVehicle
    {
        private const int SubaruImprezaWRXWeightInGrams = 1560000;
        private const int SubaruImprezaWRXAcceleration = 35;
        private const int SubaruImprezaWRXTopSpeed = 260;
        private const decimal SubaruImprezaWRXPriceInUSADollars = 55999;

        public SubaruImprezaWRX() 
            : base(
                  SubaruImprezaWRXPriceInUSADollars,
                  SubaruImprezaWRXWeightInGrams,
                  SubaruImprezaWRXTopSpeed,
                  SubaruImprezaWRXAcceleration)
        {
        }
    }
}
