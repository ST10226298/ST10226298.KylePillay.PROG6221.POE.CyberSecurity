
using System;

namespace CyberSecurityAwareness
{
    public static class UIManager
    {
        public static void ShowWelcome()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine(" Welcome to CyberSecurity Awareness ");
            Console.WriteLine("=====================================");
        }

        public static void ShowHelp()
        {
            Console.WriteLine("\nYou can ask questions such as:");
            Console.WriteLine("- What is phishing?");
            Console.WriteLine("- How can I create a strong password?");
            Console.WriteLine("- What is 2FA?");
            Console.WriteLine("- What should I do if I get hacked?");
        }

        public static void ShowGoodbye()
        {
            Console.WriteLine("\nThank you for using the CyberSecurity Awareness Chatbot. Stay safe please!");
        }
    }
}
