using System.Collections.Generic;

namespace CyberSecurityAwarenessWPF.Features
{
    public static class SimpleNLP
    {
        private static Dictionary<string, string> _responses = new Dictionary<string, string>()
        {
            { "password", "Use strong, unique passwords for each account." },
            { "phishing", "Don't click on suspicious links or attachments in emails." },
            { "privacy", "Review your privacy settings regularly." },
            { "reminder", "You can set reminders for your cybersecurity tasks." },
            { "task", "You can add or complete a task through the chatbot." },
            { "quiz", "Take the cybersecurity quiz to test your knowledge!" }
        };

        public static string Detect(string input)
        {
            foreach (var key in _responses.Keys)
            {
                if (input.ToLower().Contains(key))
                    return _responses[key];
            }
            return "I'm not sure how to help with that. Try asking about password safety, phishing, or privacy.";
        }
      
            public static string GenerateResponse(string input) // Simulates a basic NLP response by checking for keywords in the input.
        {
                input = input.ToLower();

                if (input.Contains("phish") || input.Contains("scam"))
                    return "Phishing is a common threat. Never click on suspicious links.";
                if (input.Contains("password"))
                    return "Use strong, unique passwords and consider a password manager.";
                if (input.Contains("2fa") || input.Contains("two-factor"))
                    return "Two-factor authentication adds an extra layer of protection.";
                if (input.Contains("malware") || input.Contains("virus"))
                    return "Keep your antivirus up to date to protect against malware.";
                if (input.Contains("safe") || input.Contains("secure"))
                    return "Great! Staying informed is the best defense.";

                return "That's interesting! Could you tell me more or ask another question?";
            }
        }

    
}