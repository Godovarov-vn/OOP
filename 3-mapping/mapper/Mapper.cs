//Мапперы занимаются конвертированием объекта из одного типа в другой

using System;
using DTONamespace;
using DAONamespace;

namespace MapperNamespace
{
    class Mapper : IMapper<DatabaseObject, DTO> //и в данном случае я создаю маппер, который из наших датабейс обжектов создает ДТО
    {
        public DTO Map(DatabaseObject input) //реализую метод Мар
        {
            var dto = new DTO();

            dto.FirstName = input.FirstName;
            dto.LastName = input.LastName;
            
            return dto;
        }
    }
}
