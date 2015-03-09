using System;

class TestFractions
{
    static void Main(string[] args)
    {
        Fraction f1 = (double)1 / 4;
        Console.WriteLine("f1 = {0}", f1);
        Fraction f2 = (double)7 / 10;
        Console.WriteLine("f2 = {0}", f2);
        Console.WriteLine("-f1 = {0}", -f1);
        Console.WriteLine("f1 + f2 = {0}", f1 + f2);
        Console.WriteLine("f1 - f2 = {0}", f1 - f2);
        Console.WriteLine("f1 * f2 = {0}", f1 * f2);
        Console.WriteLine("f1 / f2 = {0}", f1 / f2);
        Console.WriteLine("f1 / f2 as double = {0}", (double)(f1 / f2));
        Console.WriteLine("-(f1+f2)*(f1-f2/f1) = {0}", -(f1 + f2) * (f1 - f2 / f1));
        Console.WriteLine("++f1 = {0}", ++f1);
    }
}
