using System;
// the other project should be referenced for this using to work
using CustomDataStructures;

namespace Demos
{
    class Startup
    {
        static void Main()
        {
            var numbers = new GenericList<int>();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i);
            }

            numbers += 99;
            numbers -= 1;

            Console.WriteLine(numbers.ToString());

            numbers += new int[] { 20, 30, 40 };

            numbers.RemoveFirst(20);

            Console.WriteLine(numbers.ToString());

            numbers[3] = -3;
            numbers[7] = -7;

            Console.WriteLine(numbers.ToString());

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
