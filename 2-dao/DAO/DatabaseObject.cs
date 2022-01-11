using System;
using DAONamespace;

namespace DAONamespace
{
    class DatabaseObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Value { get; set; }

        public DatabaseObject() {} 

        public DatabaseObject(DatabaseObject obj)
        {
            FirstName = obj.FirstName;
            LastName = obj.LastName;
            Value = obj.Value;
        }

        public DatabaseObject(string firstname, string lastname, int value)
        {
            FirstName = firstname;
            LastName = lastname;
            Value = value;
        }

        public override string ToString() //метод, кот. конвертирует этот объект в строку
        {
            return $"{FirstName}:{LastName}:{Value}";
        }

        public bool Read( string str ) //метод, кот. считает данные сос строки
        {
            string[] words = str.Split(':');

            if(words.Length != 3) return false;

            FirstName = words[0];
            LastName = words[1];
            Value = int.Parse(words[2]);
            return true;
        }

        public bool Equal(DatabaseObject obj) //сравнение
        {
            return FirstName == obj.FirstName &&
                LastName == obj.LastName &&
                Value == obj.Value;
        }
    }
}
