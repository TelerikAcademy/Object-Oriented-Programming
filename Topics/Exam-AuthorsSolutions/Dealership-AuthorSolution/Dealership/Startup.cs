using Dealership.Engine;
using System;
using System.IO;

namespace Dealership
{
    public class Startup
    {
        public static void Main()
        {
            DealershipEngine.Instance.Start();
        }
    }
}
