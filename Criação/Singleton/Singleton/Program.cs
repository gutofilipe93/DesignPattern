using System;
using Singleton.db;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDatabaseClass myDatabase = MyDatabaseClass.GetInstance();
            myDatabase.AddName("Gustavo");
            myDatabase.AddName("Maria");
            myDatabase.AddName("Pedro");

            MyDatabaseClass myDatabase1 = MyDatabaseClass.GetInstance();
            myDatabase1.AddName("João");
            myDatabase1.AddName("Paula");
            myDatabase1.AddName("Algusto");

            foreach (var name in myDatabase.ShowNames())            
                Console.WriteLine(name);    

            /* A classe MyDatabaseClass funciona como uma variavel global, ou seja, como sua instancia é criada somente uma ve isso faz com que seu dados
              não apagem  */             
        }
    }
}
