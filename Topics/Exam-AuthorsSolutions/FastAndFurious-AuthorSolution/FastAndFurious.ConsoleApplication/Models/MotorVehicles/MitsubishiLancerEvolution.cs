using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    public class MitsubishiLancerEvolution : MotorVehicle
    {
        private const int MitsubishiLancerEvolutionWeightInGrams = 1780000;
        private const int MitsubishiLancerEvolutionAcceleration = 20;
        private const int MitsubishiLancerEvolutionTopSpeed = 300;
        private const decimal MitsubishiLancerEvolutionPriceInUSADollars = 56999;

        public MitsubishiLancerEvolution() 
            : base(
                  MitsubishiLancerEvolutionPriceInUSADollars,
                  MitsubishiLancerEvolutionWeightInGrams,
                  MitsubishiLancerEvolutionTopSpeed,
                  MitsubishiLancerEvolutionAcceleration)
        {
        }
    }
}
