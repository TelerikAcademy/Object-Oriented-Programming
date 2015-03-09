using System;
using System.Collections.Generic;
using System.Linq;

namespace Action_And_Func
{
    public static class ActionAndFunc
    {
        public static void Each<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }

        static void Main()
        {
            Action<int> logNumber = (number) => Console.WriteLine(number);
            logNumber(5);

            Action<string, int> logNameAge = (name, age) =>
                {
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Age: " + age);
                };

            logNameAge("Pesho", 5);

            Func<string> magic = () =>
            {
                return "Magic";
            };

            Console.WriteLine(magic());

            Func<string, int> parser = (str) => int.Parse(str);
            int someNumber = parser("50");
            Console.WriteLine(someNumber);

            string[] someStrings = new string[] { "Pesho", "Ivaylo", "Gosho", "Niki" };
            someStrings.Each(Console.WriteLine);

            someStrings.Each(str =>
                {
                    Console.Write(str + " ");
                });
        }
    }
}
