
using System;
using System.Collections.Generic;

namespace CyberSecurityAwareness
{
    public class ChatBot
    {
        private Dictionary<string, string> responses;
        private List<string> tips;
        private List<string> userHistory;
        private Random random;

        public ChatBot()
        {
            random = new Random();
            userHistory = new List<string>();

            //  this defiens the simple keywprd-resones pairs
            responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "phishing", "Phishing is a trick used to steal personal info through fake emails or websites." },
                { "password", "Use long passwords with letters, numbers, and symbols. Avoid common words." },
                { "2FA", "Two-Factor Authentication adds a second step to log in securely." },
                { "hacked", "Change all your passwords immediately and contact affected services." }
            };

            // Random tips for the prompt
            tips = new List<string>
            {
                "Never click suspicious links in emails.",
                "Update your software regularly to avoid vulnerabilities.",
                "Use a password manager to store your passwords securely.",
                "Avoid public Wi-Fi when doing banking or private tasks.",
                "Always enable Two-Factor Authentication.",
                "Backup your data to an external drive or cloud.",
                "Be careful what personal info you share online."
            };
        }

        // Responds based on keyword used to match, includes sentiment tone detection
        public string GetResponse(string input)
        {
            userHistory.Add(input);  // Records the users input for responese

            string sentiment = DetectSentiment(input);
            string baseResponse = "Sorry, I don't have any infomation on that. Try another question please.";

            foreach (var key in responses.Keys)
            {
                if (input.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    baseResponse = responses[key];
                    break;
                }
            }

            return $"{sentiment}\n{baseResponse}";
        }

        // Provides a random tips
        public string GetRandomTip()
        {
            int index = random.Next(tips.Count);
            return tips[index];
        }

        // Basic sentiment tones using keywords
        private string DetectSentiment(string input)
        {
            input = input.ToLower();
            if (input.Contains("worried") || input.Contains("scared") || input.Contains("anxious"))
                return "I can sense you're worried. It's okay—let's go over what you can do.";
            if (input.Contains("curious") || input.Contains("interested"))
                return "Great! Curiosity is key to staying safe online.";
            if (input.Contains("frustrated") || input.Contains("angry"))
                return "I'm here to help—let's take it step by step.";
            return "Let's talk cybersecurity.";
        }

        // Show previous user history questions
        public void ShowMemory()
        {
            Console.WriteLine("Here’s a history of what you’ve asked so far:");
            foreach (string entry in userHistory)
            {
                Console.WriteLine("- " + entry);
            }
        }
    }
}
