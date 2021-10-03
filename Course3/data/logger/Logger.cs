using System;
using System.Linq;

namespace Course3.data.Logger
{
    public class Logger
    {
        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Notify?.Invoke("[INFO] " + message);
            Console.ResetColor();
        }
        
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Notify?.Invoke("[ERROR] " + message);
            Console.ResetColor();
        }
        
        public event Action<string> Notify;
    }
}