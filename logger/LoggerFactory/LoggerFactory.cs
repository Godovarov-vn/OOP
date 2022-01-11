using System;
using LoggerNamespace;

namespace FactoryNamespace
{
    static class LoggerFactory
    {
        public static ILogger Create(LoggerTypes type)
        {
            switch(type)
            {
                case LoggerTypes.CONSOLE:
                    return new LoggerConsole();
                case LoggerTypes.FILE:
                    return new LoggerFile();
                default:
                    return null;
            }
        }
    }
}