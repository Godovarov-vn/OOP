using System;
using DAONamespace;

namespace DAONamespace
{
    class DatabaseObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Value1 { get; set; }
        public int Value2 {get; set; }
        public int Value3 {get; set; }

        public DatabaseObject() {} 

        public DatabaseObject(DatabaseObject obj)
        {
            FirstName = obj.FirstName;
            LastName = obj.LastName;
            Value1 = obj.Value1;
            Value2 = obj.Value2;
            Value3 = obj.Value3;
        }

        public DatabaseObject(string firstname, string lastname, int value1, int value2, int value3)
        {
            FirstName = firstname;
            LastName = lastname;
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        public override string ToString()
        {
            return $"{FirstName}:{LastName}:{Value1}:{Value2}:{Value3}";
        }

        public bool Read( string str )
        {
            string[] words = str.Split(':');

            if(words.Length != 5 ) return false;

            FirstName = words[0];
            LastName = words[1];
            Value1 = int.Parse(words[2]);
            Value2 = int.Parse(words[3]);
            Value3 = int.Parse(words[4]);
            return true;
        }

        public bool Equal(DatabaseObject obj)
        {
            return FirstName == obj.FirstName &&
                LastName == obj.LastName &&
                Value1 == obj.Value1 &&
                Value2 == obj.Value2 &&
                Value3 == obj.Value3;
        }
    }
}