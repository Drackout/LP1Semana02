using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string questao;
            bool running = true;

            do
            {
                Console.WriteLine("Faz-me uma Pergunta!");
                questao = Console.ReadLine();

                switch (questao)
                {
                    case "name":
                        Console.WriteLine("My name is Optimus Prime!");
                        break;

                    case "year":
                        Console.WriteLine("2025");
                        break;

                    case "banana":
                        Console.WriteLine("BANANA!");
                        break;

                    case "hello":
                        Console.WriteLine("Hello human");
                        break;
                        
                    case "EXIT":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Não reconheço essa pergunta...");
                        break;
                }
            } while (running);
        }
    }
}
