using System;

namespace DTONamespace
{
    interface IDTO
    {
        string Serialization();
        bool Deserialization(string data);
    }

}