using System;
using System.Collections.Generic;
using DAONamespace;

class Program
{
    const string PATH = "file.txt";
    static void Main()
    {
        var dao = new DAO(PATH);
        int size = dao.Length();


        string mode = Console.ReadLine();

        if(mode == "read")
        {
            for(int i=0; i < size; i++)
            {
                Console.WriteLine(dao.GetByIndex(i).ToString());
            }
            return;
        }

        if(mode == "find")
        {
            for(int i =0; i < size; i++)
            {
                Console.WriteLine( dao.FindObject(dao.GetByIndex(i)) );
            }
        }

        if(mode == "add")
        {
            string line = Console.ReadLine();
            int newSize = int.Parse(line);

            for(int i =0; i < newSize; i++)
            {
                dao.AddObjcet(new DatabaseObject($"first name #{i}", $"second name #{i}", 1000*i));
            }
        }

        if(mode == "remove")
        {
            string line = Console.ReadLine();
            int index = int.Parse(line);

            dao.RemoveByIndex(index);
        }
    }
}