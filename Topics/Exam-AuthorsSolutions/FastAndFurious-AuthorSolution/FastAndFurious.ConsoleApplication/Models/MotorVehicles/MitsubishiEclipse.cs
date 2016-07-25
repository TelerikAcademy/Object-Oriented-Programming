using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    public class MitsubishiEclipse : MotorVehicle
    {
        private const int MitsubishiEclipseWeightInGrams = 1400000;
        private const int MitsubishiEclipseAcceleration = 24;
        private const int MitsubishiEclipseTopSpeed = 230;
        private const decimal MitsubishiEclipsePriceInUSADollars = 29999;

        public MitsubishiEclipse() 
            : base(
                  MitsubishiEclipsePriceInUSADollars, 
                  MitsubishiEclipseWeightInGrams,
                  MitsubishiEclipseTopSpeed, 
                  MitsubishiEclipseAcceleration)
        {
        }
    }
}
