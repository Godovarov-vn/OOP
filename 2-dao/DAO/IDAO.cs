using System;
using System.Collections.Generic;

namespace DAONamespace
{
    abstract class IDAO //ставлю абстрактный класс, т.к. нужно было скрыть некоторые методы (protected)
    {

        protected abstract List<DatabaseObject> GetAllObjects();

        protected abstract void OverwriteAllOjbects(List<DatabaseObject> list);

        public abstract bool FindObject( DatabaseObject obj);

        public abstract DatabaseObject GetByIndex(int i);

        public abstract bool AddObjcet(DatabaseObject obj);

        public abstract bool RemoveObject( DatabaseObject obj);

        public abstract void RemoveByIndex( int i);

        public abstract int Length();
 
    }
}
