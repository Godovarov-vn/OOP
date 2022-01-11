using System;
using System.Collections.Generic;
using DTONamespace;
using DAONamespace;
using MapperNamespace;

class Program
{
    const string PATH = "file.txt";

    static void PrintDTO(DTO dto)
    {
        Console.WriteLine("DTO:");
        Console.WriteLine( $"\tFirst Name: {dto.FirstName}" );
        Console.WriteLine( $"\tLast Name: {dto.FirstName}" );
    }

    static void Main()
    {
        var buffer = new List<string>();

        DTO dto = new DTO();
        var dao = new DAO( PATH );
        var mapper = new Mapper();

        int size = dao.Length();

        Console.WriteLine("--------SERVER--------");

        for(int i =0; i < size; i++)
        {

            dto = mapper.Map( dao.GetByIndex(i) );

            PrintDTO(dto);
            Console.WriteLine();

            buffer.Add( dto.Serialization() );
        }

        Console.WriteLine("--------USER----------");

        for(int i =0; i < size; i++)
        {
            dto.Deserialization( buffer[i] );

            PrintDTO(dto);
            Console.WriteLine();
        }
    }
}