using System;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;


namespace NoirLog
{
    public class NoirLogger
    {
        public string Path { get; set ; }

        public enum LogLevel
        {
            Info = 0,
            Debug = 1,
            Warning = 2,
            Error = 3
        }

        public NoirLogger(string path)
        {
            Path = path;
        }

        public void WriteToFile(LogLevel logLevel, string text)
        {
            string timeStamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            string logText = $"{timeStamp} - [{logLevel.ToString().ToUpper()}]: {text}\n";
            File.AppendAllText(Path, logText);
        }

        public void Info(string text)
        {
            string timeStamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            string logText = $"{timeStamp} - [INFO]: {text}\n";
            File.AppendAllText(Path, logText);
        }

        public void Debug(string text)
        {
            string timeStamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            string logText = $"{timeStamp} - [DEBUG]: {text}\n";
            File.AppendAllText(Path, logText);
        }

        public void Warning(string text)
        {
            string timeStamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            string logText = $"{timeStamp} - [WARNING]: {text}\n";
            File.AppendAllText(Path, logText);
        }

        public void Error(string text)
        {
            string timeStamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            string logText = $"{timeStamp} - [ERROR]: {text}\n";
            File.AppendAllText(Path, logText);
        }
    }
}
