using System;
using DTONamespace;
using DAONamespace;

namespace MapperNamespace
{
    class Mapper : IMapper<DatabaseObject, DTO>
    {
        public DTO Map(DatabaseObject input)
        {
            var dto = new DTO();

            dto.FirstName = input.FirstName;
            dto.LastName = input.LastName;
            
            return dto;
        }
    }
}