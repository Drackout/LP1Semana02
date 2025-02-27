using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //part 1 
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);
            
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);
            
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);
            
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            //part 2 
            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.NaN);
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.NaN);

        }
    }
}
