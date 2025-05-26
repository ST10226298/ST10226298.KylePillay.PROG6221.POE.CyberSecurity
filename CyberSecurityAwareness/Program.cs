
using System;

namespace CyberSecurityAwareness
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatBot bot = new ChatBot();
            UIManager.ShowWelcome();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Ask a question");
                Console.WriteLine("2. Get a cybersecurity tip");
                Console.WriteLine("3. View my question history");
                Console.WriteLine("4. Help");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Ask your question: ");
                        string question = Console.ReadLine();
                        string answer = bot.GetResponse(question);
                        Console.WriteLine(answer);
                        break;
                    case "2":
                        Console.WriteLine("Tip: " + bot.GetRandomTip());
                        break;
                    case "3":
                        bot.ShowMemory();
                        break;
                    case "4":
                        UIManager.ShowHelp();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid reply. Please try again.");
                        break;
                }
            }

            UIManager.ShowGoodbye();
        }
    }
}
