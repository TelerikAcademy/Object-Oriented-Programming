using System;

namespace FastAndFurious.ConsoleApplication.Common.Utils
{
    public static class MetricUnitsConverter
    {
        private const int MinutesInHour = 60;
        private const int SecondsInMinute = 60;
        private const decimal MetersInAKilometer = 1000m;

        public static int GetMetersPerSecondFrom(int kilometersPerHour)
        {
            var expression = (kilometersPerHour * MetersInAKilometer) / (MinutesInHour * SecondsInMinute);
            var metersPerSecond = Convert.ToInt32(Math.Ceiling(expression));

            return metersPerSecond;
        }
    }
}
