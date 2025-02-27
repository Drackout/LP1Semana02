using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // EXERCICIO 6 
            // part 1 
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

            // part 2 
            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.NaN);
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.NaN);

            
            Console.WriteLine("\n");
            // EXERCICIO 7 
            uint var1 = uint.MaxValue;
            Console.WriteLine(var1++);
            Console.WriteLine(var1);

            float var2 = float.MaxValue;
            var2 *= 1.5f;
            Console.WriteLine(var2);
            
            float var3 = float.MaxValue;
            var3 *= var3;
            Console.WriteLine(var3);

            float var4, var5;
            var4 = var5 = 45.0f;
            var4 += 0.0000009f;
            Console.WriteLine(var4 == var5);
        }
    }
}
