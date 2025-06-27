using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using CyberSecurityAwarenessWPF.Features;
using CyberSecurityAwarenessWPF.Models;
using CyberSecurityAwarenessWPF.Views;

namespace CyberSecurityAwarenessWPF
{
    public partial class MainWindow : Window
    {
        private List<Task> tasks = new List<Task>();

        // Initializes the main window, sets up UI components and logs app start.
        public MainWindow() 
        {
            InitializeComponent();
            ActivityLogger.Log("Application started.");
            RefreshTaskList();

            ChatBubbleList.Items.Add("Bot: Welcome! How can I assist you today?"); // Add welcome message to chat
        }

        // Handles the Send button click to simulate NLP response and log interaction.
        private void Send_Click(object sender, RoutedEventArgs e) 

        {
            string input = UserInput.Text;
            if (!string.IsNullOrWhiteSpace(input))
            {
                ChatBubbleList.Items.Add("You: " + input);
                string response = SimpleNLP.GenerateResponse(input);
                ChatBubbleList.Items.Add("Bot: " + response);
                ActivityLogger.Log("User asked: " + input);
                UserInput.Clear();
            }
        }

        private void StartQuiz_Click(object sender, RoutedEventArgs e) // Launches the quiz window as a dialog for cybersecurity knowledge testing.
        {
            QuizWindow quizWindow = new QuizWindow();
            quizWindow.ShowDialog();
        }

        private void ShowLog_Click(object sender, RoutedEventArgs e) // Displays logged user-bot interactions in the chat window.
        {
            var logs = ActivityLogger.GetLog();
            ChatBubbleList.Items.Add("Activity Log:");
            foreach (var entry in logs)
            {
                ChatBubbleList.Items.Add("• " + entry);
            }
        }

        private void RefreshTaskList()
        {
            // Placeholder for task refresh logic
        }

        private void ToggleDarkMode_Click(object sender, RoutedEventArgs e) // Switches to the Dark Mode theme by reloading the resource dictionary.
        {
            var uri = new Uri("Themes/DarkMode.xaml", UriKind.Relative);
            var resourceDict = new ResourceDictionary { Source = uri };
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string input = UserInput.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                ChatBubbleList.Items.Add("User: " + input);
                string response = SimpleNLP.GenerateResponse(input);
                ChatBubbleList.Items.Add("Bot: " + response);
                ActivityLogger.Log($"User input: {input} | Bot response: {response}");
                UserInput.Clear();
            }
        }

        private void StartQuizButton_Click(object sender, RoutedEventArgs e)
        {
            QuizWindow quizWindow = new QuizWindow();
            quizWindow.ShowDialog();
        }

        private void ShowLogButton_Click(object sender, RoutedEventArgs e)
        {
            var logs = ActivityLogger.GetLog();
            ChatBubbleList.Items.Add("Activity Log:");
            foreach (var entry in logs)
            {
                ChatBubbleList.Items.Add(entry);
            }
        }

        private void ToggleThemeButton_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary newTheme = new ResourceDictionary();
            newTheme.Source = new Uri("Themes/DarkMode.xaml", UriKind.Relative);

            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(newTheme);
        }

    }
}