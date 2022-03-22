using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double raio;
            double pi = Math.PI;
            double volume;

            Console.Write("Altura:");
            altura = double.Parse(Console.ReadLine());
            
            Console.Write("Raio:");
            raio = double.Parse(Console.ReadLine());

            volume = pi*Math.Pow(raio, 2)*altura;
            Console.WriteLine(volume);

            volume = 2*pi*raio*(raio+altura);
            Console.WriteLine(volume);
        }
    }
}
