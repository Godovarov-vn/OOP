/* 
 Логгеры делают логи. Лог – это стандартизированный методы вывода информации о текущем состоянии системы.
 */

using System;
using LoggerNamespace;
using FactoryNamespace;

class Program
{
    static void Main()
    {
        ILogger logger = LoggerFactory.Create(LoggerTypes.CONSOLE);         //если написать LoggerTypes.CONSOLE , то выведет в консоль сообщения. .FILE для вывода в файл

        for (int i = 0; i < 3; i++)                                         //просто цикл для того, чтобы продемонстрировать все типы сообщений
        {            
            logger.Message("message #" + (i + 1).ToString(), (MessageTypes)i);              //применяю метод Message который прописан в интерфейсе логгера, Message(строка сообщения, тип сообщения (см. MessageTypes.cs)) 
        }
    }
}
