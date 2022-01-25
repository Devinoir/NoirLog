using System;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;


namespace NoirLog
{
    public class NoirLogger
    {
        public string Path { get; set ; }
        public bool ConsoleOutput { get; set; }

        public enum LogLevel
        {
            Info = 0,
            Debug = 1,
            Warning = 2,
            Error = 3
        }

        public NoirLogger(string path, bool consoleOutput = true)
        {
            Path = path;
            ConsoleOutput = consoleOutput;
        }

        public void Add(string text, LogLevel logLevel = LogLevel.Info)
        {
            string timeStamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            string logText = $"{timeStamp} - [{logLevel.ToString().ToUpper()}]: {text}";
            File.AppendAllText(Path, logText + "\n");
            if (ConsoleOutput)
                Console.WriteLine(logText);
        }

        public void Add(string text, bool consoleOutput, LogLevel logLevel = LogLevel.Info)
        {
            string timeStamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            string logText = $"{timeStamp} - [{logLevel.ToString().ToUpper()}]: {text}\n";
            File.AppendAllText(Path, logText);
            if (consoleOutput)
                Console.WriteLine(logText);
        }

        public void Info(string text)
        {
            Add(text, LogLevel.Info);
        }

        public void Debug(string text)
        {
            Add(text, LogLevel.Debug);
        }

        public void Warning(string text)
        {
            Add(text, LogLevel.Warning);
        }

        public void Error(string text)
        {
            Add(text, LogLevel.Error);
        }
    }
}