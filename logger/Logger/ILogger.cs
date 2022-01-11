using System;

namespace LoggerNamespace
{
    abstract class ILogger
    {
        public abstract void Message(string message, MessageTypes type);

        public void Info(string message)
        {
            Message(message, MessageTypes.INFO);
        }

        public void Warning(string message)
        {
            Message(message, MessageTypes.WARNING);
        }

        public void Error(string message)
        {
            Message(message, MessageTypes.ERROR);
        }

        public void Fatal(string message)
        {
            Message(message, MessageTypes.FATAL);
        }
    }
}