using System;
using System.Collections.Generic;
using System.Text;

namespace IsAndAsOperators
{
    class Base { }

    class Derived : Base { }

    class PalyWithOperatorsIsAndAs
    {
        static void Main(string[] args)
        {
            Object objBase = new Base();
            if (objBase is Base)
                Console.WriteLine("objBase is Base");
            // Result: objBase is Base

            if (!(objBase is Derived))
                Console.WriteLine("objBase is not Derived");
            // Result : objBase is not Derived

			if (objBase is System.Object)
				Console.WriteLine("objBase is System.Object");
			// Result : objBase is System.Object

			// "dynamic" is internally System.Object
			// but with runtime binding of the operations
			if (objBase is dynamic)
				Console.WriteLine("objBase is dynamic");
			// Result: objBase is dynamic
			
			Base b = objBase as Base;
            Console.WriteLine("b = {0}", b);
            // Result: b = Base

            Derived d = objBase as Derived;
            if (d == null)
                Console.WriteLine("d is null");
            // Result: d is null

			Object o = objBase as object;
			Console.WriteLine("o = {0}", o);
			// Result: o = Base

            Derived der = new Derived();
            Base bas = der as Base;
            Console.WriteLine("bas = {0}", bas);
            // Result: bas = Derived

			Object dyn = objBase as dynamic;
			Console.WriteLine("dyn = {0}", dyn);
			// Result: o = Base
		}
    }
}