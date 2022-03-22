using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura;
            float raio;
            float pi = 3.1315926f;
            float volume;

            Console.Write("Altura:");
            altura = float.Parse(Console.ReadLine());
            
            Console.Write("Raio:");
            raio = float.Parse(Console.ReadLine());

            volume = pi*(raio*raio)*altura;
            Console.WriteLine(volume);

            volume = 2*pi*raio*(raio+altura);
            Console.WriteLine(volume);
        }
    }
}
