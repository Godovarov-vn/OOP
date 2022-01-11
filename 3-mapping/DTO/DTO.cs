//ДТО -дата транспорт обжект
using System;

namespace DTONamespace
{
    class DTO : IDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Serialization() //конвертирует нашу ДТОшку в какой нибудь массив байт, чтобы отправить по сети
        {
            return $"{FirstName}:{LastName}";
        }

        public bool Deserialization(string data)    //принимает этот массив байт и восстанавливает по нему сообщение
        {
            string[] words = data.Split(':');

            if(words.Length != 2) return false;

            FirstName = words[0];
            LastName = words[1];
            return true;
        }

    }
}
