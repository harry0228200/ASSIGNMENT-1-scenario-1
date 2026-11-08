using System;
using System.IO;

namespace ASSIGNMENT_1.Patterns
{
    public class BattleLogger
    {
        private static BattleLogger _instance = new BattleLogger();
        private string _logFilePath = "battle_log.txt";

        // Private constructor
        private BattleLogger() { }

        // Singleton Instance
        public static BattleLogger Instance
        {
            get { return _instance; }
        }

        public void Log(string message)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
            Console.WriteLine(logEntry);

            try
            {
                File.AppendAllText(_logFilePath, logEntry + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to log file: " + ex.Message);
            }
        }
    }
}
