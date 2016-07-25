using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    public class NissanSkylineR34 : MotorVehicle
    {
        private const int NissanSkylineR34WeightInGrams = 1850000;
        private const int NissanSkylineR34Acceleration = 50;
        private const int NissanSkylineR34TopSpeed = 280;
        private const decimal NissanSkylineR34PriceInUSADollars = 45999;

        public NissanSkylineR34() 
            : base(
                  NissanSkylineR34PriceInUSADollars,
                  NissanSkylineR34WeightInGrams,
                  NissanSkylineR34TopSpeed,
                  NissanSkylineR34Acceleration)
        {
        }
    }
}
