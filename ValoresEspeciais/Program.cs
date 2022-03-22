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

        }
    }
}
