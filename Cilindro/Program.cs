using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double altura = double.Parse(Console.ReadLine());
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine($"{Math.PI*(Math.Pow(raio, 2f))*altura:f3}");

            Console.WriteLine($"{2*Math.PI*raio*(raio+altura):f3}");
        }
    }
}
