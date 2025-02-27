using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            sbyte valor;
            valor = sbyte.Parse(Console.ReadLine());

            Console.WriteLine(--valor);
            Console.WriteLine(++valor);
        }
    }
}
