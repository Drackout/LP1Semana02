using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            byte numInt = byte.Parse(Console.ReadLine());

            Console.WriteLine(numInt/2);
            Console.WriteLine(numInt<<3);
            Console.WriteLine(numInt^6);
            Console.WriteLine(numInt>10);

        }
    }
}
