using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Console.WriteLine(x);
            Console.WriteLine(x++);
            Console.WriteLine(x);
            
            Console.WriteLine(y);
            Console.WriteLine(--y);
            Console.WriteLine(y);
        }
    }
}
