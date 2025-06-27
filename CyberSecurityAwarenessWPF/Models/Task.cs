using System;

namespace CyberSecurityAwarenessWPF.Models
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Reminder { get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            return $"{Title} - {(IsCompleted ? "Completed" : "Pending")} {(Reminder.HasValue ? $"(Reminder: {Reminder.Value.ToShortDateString()})" : "")}";
        }
    }
}