using System.Collections.Generic;

namespace CyberSecurityAwarenessWPF.Features
{
    public class Question
    {
        public string Prompt { get; set; }
        public string[] Options { get; set; }
        public int CorrectIndex { get; set; }
        public string Explanation { get; set; }
    }

    public static class QuizManager
    {
        public static List<Question> GetQuestions() // Loads quiz questions related to cybersecurity awareness.
        {
            return new List<Question>
            {
                new Question {
                    Prompt = "What should you do if you receive a suspicious email?",
                    Options = new[] { "Ignore it", "Click the link", "Report it", "Reply to it" },
                    CorrectIndex = 2,
                    Explanation = "Always report suspicious emails to your IT department or service provider."
                },
                new Question {
                    Prompt = "What makes a strong password?",
                    Options = new[] { "123456", "Your birthdate", "A mix of letters, numbers and symbols", "Just letters" },
                    CorrectIndex = 2,
                    Explanation = "A strong password should be complex and hard to guess."
                },
                       new Question {
            Prompt = "Which of these is a sign of a phishing email?",
            Options = new[] { "Generic greeting", "Personalized domain", "No links", "Encrypted attachments" },
            CorrectIndex = 0,
            Explanation = "Phishing emails often use generic greetings like 'Dear user'."
        },
        new Question {
            Prompt = "How often should you update your passwords?",
            Options = new[] { "Once a year", "Only when prompted", "Regularly (every few months)", "Never" },
            CorrectIndex = 2,
            Explanation = "Regularly updating passwords reduces the risk of compromise."
        },
        new Question {
            Prompt = "What does 2FA stand for?",
            Options = new[] { "Two-Factor Authentication", "Two-Firewall Access", "Twice Filtered Access", "Token-Free Authentication" },
            CorrectIndex = 0,
            Explanation = "2FA adds a second layer of security to your login process."
        },
        new Question {
            Prompt = "Which password is most secure?",
            Options = new[] { "password123", "qwerty", "J$8f!k9#Tz", "abc123" },
            CorrectIndex = 2,
            Explanation = "A mix of characters and symbols is the strongest."
        },
        new Question {
            Prompt = "You should never share your passwords via:",
            Options = new[] { "Phone call", "Email", "Text message", "All of the above" },
            CorrectIndex = 3,
            Explanation = "Passwords should never be shared over insecure channels."
        },
        new Question {
            Prompt = "What's the best way to identify a secure website?",
            Options = new[] { "Starts with http://", "Flashing icons", "Uses HTTPS and has a padlock", "Lots of popups" },
            CorrectIndex = 2,
            Explanation = "Secure websites use HTTPS and show a padlock in the browser."
        },
        new Question {
            Prompt = "What is social engineering?",
            Options = new[] { "Writing secure code", "Using firewalls", "Manipulating people to give up confidential info", "Encrypting data" },
            CorrectIndex = 2,
            Explanation = "Social engineering exploits human psychology to gain access."
        },
        new Question {
            Prompt = "What should you do before clicking a link in an email?",
            Options = new[] { "Click it quickly", "Forward it", "Hover over it to preview", "Reply to the sender" },
            CorrectIndex = 2,
            Explanation = "Hovering reveals the actual destination URL of the link."
        }

            };
        }
    }
}