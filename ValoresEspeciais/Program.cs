using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.MaxValue;
            float f = float.MaxValue;
            decimal m = decimal.MaxValue;
            double d = double.MaxValue;
            short sh = short.MaxValue;
            long lo = long.MaxValue;

            Console.WriteLine(i);
            Console.WriteLine(f);
            Console.WriteLine(m);
            Console.WriteLine(d);
            Console.WriteLine(sh);
            Console.WriteLine(lo);
            
            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.NaN);

            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.NaN);

            //overflow
            double overflow1 = 2 * double.MaxValue;
            double overflow2 = double.MaxValue+1;
            Console.WriteLine(overflow1);
            Console.WriteLine(overflow2);

            //underflow
            float f1 , f2 ;
            f1 = f2 = 9999.0f;
            Console.WriteLine(f1 == f2 + 0.0001f);

            f1 = f2 = 999999.0f;
            Console.WriteLine(f1 == f2 + 0.001f);


        }
    }
}
