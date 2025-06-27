using System;
using System.Collections.Generic;

namespace CyberSecurityAwarenessWPF.Features
{
    public static class ActivityLogger
    {
        private static List<string> log = new List<string>(); // Logs system events and user interactions with timestamp.

        public static void Log(string entry)
        {
            log.Add($"{DateTime.Now}: {entry}");
        }

        public static List<string> GetLog() // Returns the log history for display or export.

        {
            return log;
        }
    }
}
