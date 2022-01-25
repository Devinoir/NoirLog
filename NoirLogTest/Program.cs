using System;
using NoirLog;

namespace NoirLogTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new NoirLogger(@"C:\Users\devin\Repository\log.txt");

            logger.Info("Info Test");
            logger.Debug("Debug Test");
            logger.Warning("Warning Test");
            logger.Error("Error Test");

            Console.Read();
        }
    }
}
