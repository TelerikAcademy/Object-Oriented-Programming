using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    public class Nissan350Z : MotorVehicle
    {
        private const int Nissan350ZWeightInGrams = 1280000;
        private const int Nissan350ZAcceleration = 55;
        private const int Nissan350ZTopSpeed = 220;
        private const decimal Nissan350ZPriceInUSADollars = 25999;

        public Nissan350Z() 
            : base(
                  Nissan350ZPriceInUSADollars,
                  Nissan350ZWeightInGrams,
                  Nissan350ZTopSpeed,
                  Nissan350ZAcceleration)
        {
        }
    }
}
