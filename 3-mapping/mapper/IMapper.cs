using System;

namespace MapperNamespace
{
    interface IMapper<in I, out O>
    {
        O Map(I input);
    }
}