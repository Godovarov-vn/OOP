using System;

namespace DTONamespace
{
    class DTO : IDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Serialization()
        {
            return $"{FirstName}:{LastName}";
        }

        public bool Deserialization(string data)
        {
            string[] words = data.Split(':');

            if(words.Length != 2) return false;

            FirstName = words[0];
            LastName = words[1];
            return true;
        }

    }
}