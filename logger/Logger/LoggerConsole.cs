using System;

namespace LoggerNamespace
{
    class LoggerConsole : ILogger
    {
        private static readonly ConsoleColor[] MessageTypeToColor = new[]{
            ConsoleColor.White,
            ConsoleColor.Yellow,
            ConsoleColor.Red,
            ConsoleColor.Red
        };

        public override void Message(string message, MessageTypes type)
        {
            Console.ForegroundColor = MessageTypeToColor[(int)type];
            Console.WriteLine(
                (DateTime.Now).ToString() +
                $"\t[{type.ToString()}]\t" +
                message
            );
        } 
    }
}
