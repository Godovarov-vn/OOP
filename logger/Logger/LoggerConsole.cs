using System;

namespace LoggerNamespace
{
    class LoggerConsole : ILogger
    {
        public override void Message(string message, MessageTypes type)
        {
            Console.WriteLine
                (
                (DateTime.Now).ToString() +
                $"\t[{type.ToString()}]\t" +
                message
                );
        }
    }
}
