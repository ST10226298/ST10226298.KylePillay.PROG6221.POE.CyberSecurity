using System.Windows;
using System.Collections.Generic;

using CyberSecurityAwarenessWPF.Features;

namespace CyberSecurityAwarenessWPF.Views
{
    public partial class QuizWindow : Window
    {
        private List<Question> questions;
        private int currentIndex = 0;
        private int score = 0;

        public QuizWindow()
        {
            InitializeComponent();
            questions = QuizManager.GetQuestions();
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            if (currentIndex >= questions.Count)
            {
                QuestionText.Text = $"Quiz complete! You scored {score}/{questions.Count}.";
                OptionsList.Visibility = Visibility.Collapsed;
                FeedbackText.Text = score > 7 ? "Great job! You're a cybersecurity pro!" :
                                    score > 4 ? "Good effort! Keep learning to stay safe online!" :
                                                "Keep practicing to improve your cybersecurity awareness.";
                return;
            }

            var q = questions[currentIndex];
            QuestionText.Text = q.Prompt;
            OptionsList.ItemsSource = q.Options;
            OptionsList.SelectedIndex = -1;
            FeedbackText.Text = "";
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (OptionsList.SelectedIndex == -1)
            {
                FeedbackText.Text = "Please select an answer.";
                return;
            }

            var q = questions[currentIndex];
            if (OptionsList.SelectedIndex == q.CorrectIndex)
            {
                score++;
                FeedbackText.Text = "Correct! " + q.Explanation;
            }
            else
            {
                FeedbackText.Text = "Incorrect. " + q.Explanation;
            }

            currentIndex++;
            LoadQuestion();
        }
    }
}