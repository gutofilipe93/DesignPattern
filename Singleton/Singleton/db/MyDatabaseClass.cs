using System.Collections.Generic;

namespace Singleton.db
{
    public class MyDatabaseClass
    {
        private static MyDatabaseClass instance;

        private List<string> _names = new List<string>();

        private MyDatabaseClass(){}

        public static MyDatabaseClass GetInstance ()
        {
            if(MyDatabaseClass.instance == null)
                MyDatabaseClass.instance = new MyDatabaseClass();

            return MyDatabaseClass.instance ;               
        }

        public void AddName(string name)
        {
            _names.Add(name);
        }

        public List<string> ShowNames()
        {
            return _names;
        }

    }
}