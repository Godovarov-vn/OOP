using System;
using LoggerNamespace;
using FactoryNamespace;

class Program
{
    static void Main()
    {
        ILogger logger = LoggerFactory.Create(LoggerTypes.FILE);

        for(int i = 0; i < 4; i++)
        {
            logger.Message("message #" + (i + 1).ToString(), (MessageTypes)i);
        }
    }
}