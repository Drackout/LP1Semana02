using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string question = "";
            string response;

            //Ask a question

            do
            {
                
                Console.WriteLine("Gimme a Question!");
                question = Console.ReadLine();
                
                response = question switch
                {
                    "How are you?" => "Fine, Thanks!",
                    "What's Up?" => "The Sky!",
                    "How old are you?" => "yes..?",
                    "EXIT" => "",
                    _ => "Can't understand.. new one!"
                };

                Console.WriteLine(response);
                
            } while (question != "EXIT");




        }
    }
}
