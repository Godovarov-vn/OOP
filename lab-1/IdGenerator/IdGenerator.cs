/* Создает айдишники для продавцов и товаров (по красоте)*/
using System;

namespace IdGeneratorNamespace
{
    static class IdGenerator
    {
        static private int productCount =0;
        static private int ownerCount =0;

        public static int Generate(IdTypes type)
        {
            switch(type)
            {
                case IdTypes.PRODUCT:
                    return productCount++;
                case IdTypes.OWNER:
                    return ownerCount++;
                default:
                    return -1;
            }
        }
    }
}
