namespace Societies.Core.Infrastructure.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public static class DataGenerator
    {
        private static int counter;
        private static string[] maleNames;
        private static string[] femaleNames;
        private static Random random;

        static DataGenerator()
        {
            counter = 0;
            maleNames = new string[]
            {
                "Gosho",
                "Tosho",
                "Pesho",
                "Tobi",
                "Anton",
                "Vladimir",
                "Trendafil",
                "Bobi",
                "Vanio"
            };

            femaleNames = new string[]
            {
                "Victoria",
                "Veronica",
                "Angelina",
                "Karolina",
                "Petya",
                "Mariela",
                "Mariyana"
            };

            random = new Random();
        }

        public static int GenerateUniqueId()
        {
            return Interlocked.Increment(ref counter);
        }
        public static string GenerateMaleName()
        {
            var index = random.Next(0, maleNames.Length);
            return maleNames[index];
        }
        public static string GenerateFemaleName()
        {
            var index = random.Next(0, femaleNames.Length);
            return femaleNames[index];
        }
        public static int GenerateAge()
        {
            return random.Next(18, 40);
        }
        public static decimal GenerateTotalPrice(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}