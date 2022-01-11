using System;
using System.IO;

namespace LoggerNamespace
{
    class LoggerFile : ILogger
    {
        public const string FILE_PATH = "log.txt";

        private static StreamWriter sw; //StreamWriter - уже реализованный в интернете класс, позволяет записывать в файл

        public LoggerFile()
        {
            sw = new StreamWriter(FILE_PATH, append: true);     //тут мы создаём объект
        }

        ~LoggerFile()       //метод завершения(как деструктор)
        {
            sw.Close();
        }

        public override void Message(string message, MessageTypes type)
        {
            sw.WriteLine(
                (DateTime.Now).ToString() +         //выводим дату, которая конвертируется в строку,
                $"\t[{type.ToString()}]\t" +        //тип и само сообщение
                message
            );
        }
    }
}
