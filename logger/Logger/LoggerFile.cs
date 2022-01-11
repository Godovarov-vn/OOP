using System;
using System.IO;

namespace LoggerNamespace
{
    class LoggerFile : ILogger
    {
        public const string FILE_PATH = "log.txt";

        private static StreamWriter sw;

        public LoggerFile()
        {
            sw = new StreamWriter(FILE_PATH, append: true);
        }

        ~LoggerFile()
        {
            sw.Close();
        }

        public override void Message(string message, MessageTypes type)
        {
            sw.WriteLine(
                (DateTime.Now).ToString() +
                $"\t[{type.ToString()}]\t" +
                message
            );
        }
    }
}