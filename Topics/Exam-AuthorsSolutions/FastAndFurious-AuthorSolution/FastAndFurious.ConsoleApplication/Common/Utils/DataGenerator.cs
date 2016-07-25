using System.Threading;

namespace FastAndFurious.ConsoleApplication.Common.Utils
{
    public static class DataGenerator
    {
        private static int idCounter;

        static DataGenerator()
        {
            idCounter = 0;
        }

        public static int GenerateId()
        {
            return Interlocked.Increment(ref idCounter);
        }
    }
}
