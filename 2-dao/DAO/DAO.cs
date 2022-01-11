using System;
using System.IO;
using System.Collections.Generic;

namespace DAONamespace
{ 
    class DAO : IDAO  //реализую этот абстр.класс
    {
        static private string _path;

        public DAO(string path)
        {
            _path = path; 
        }

        protected override List<DatabaseObject> GetAllObjects()
        {
            var list = new List<DatabaseObject>(); 

            using (var sr = new StreamReader(_path))
            {
                var obj = new DatabaseObject();
                string line;

                while( ( line = sr.ReadLine() ) != null )
                {
                    if( ! obj.Read( line )) return null;

                    list.Add( new DatabaseObject(obj) );
                }
            }
            return list;
        }

        protected override void  OverwriteAllOjbects(List<DatabaseObject> list)
        {
            using (var sw = new StreamWriter(_path))
            {
                foreach(var e in list)
                {
                    sw.WriteLine( e.ToString() );
                }
            }   
        }

        public override  bool FindObject(DatabaseObject obj)
        {
            var list = GetAllObjects();

            foreach(var e in list)
            {
                if( obj.Equal(e) ) return true;
            }
            return false;
        }

        public override DatabaseObject GetByIndex(int i)
        {
            var list = GetAllObjects();
            return list[i];
        }

        public override bool AddObjcet(DatabaseObject obj)
        {
            if( FindObject(obj) ) return false;

            var list = GetAllObjects();
            list.Add(obj);

            OverwriteAllOjbects(list);
            return true;
        }

        public override bool RemoveObject(DatabaseObject obj)
        {
            var list = GetAllObjects();
            foreach( var e in list)
            {
                if( obj.Equal(e) )
                {
                    list.Remove(e);
                    OverwriteAllOjbects(list);
                    return true;
                }
            }
            return false;
        }

        public override void RemoveByIndex(int i)
        {
            var list = GetAllObjects();
            list.RemoveAt(i);
            OverwriteAllOjbects(list);
        }

        public override int Length()
        {
            return GetAllObjects().Count;
        }

    }
}
