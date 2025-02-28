using System;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            bool running = true;
            do
            {
                // Ask number
                Console.Write("Start number: ");
                int start = int.Parse(Console.ReadLine());
                Console.Write("Step number: ");
                int step = int.Parse(Console.ReadLine());

                // Verifications
                if(start<=0 || (step >1 && start < step))
                {
                    Console.WriteLine("Out-of-range start or step. Try again.");
                    continue;
                }
                else if (step >= start)
                {
                    Console.WriteLine("Start must be higher than step. Try again.");
                    continue;
                }
                else if (start % step != 0)
                {
                    Console.WriteLine("Start not divisible by step. Try again.");
                    continue;
                }
                else
                {
                    // Countdown till 0
                    do
                    {
                        Console.WriteLine(start);
                        start -= step;
                    } while (start >= 0);
                    running = false;
                }
            } while (running);
        }
    }
}
