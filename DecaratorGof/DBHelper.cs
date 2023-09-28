using System;

namespace DecaratorGof
{
    public class DBHelper : IDBHelper
    {
        public void Get()
        {
            Console.WriteLine("Main get çalıştırıldı.");
        }
        public void Save()
        {
            Console.WriteLine("Main save çalıştırıldı.");
        }
        public void Update()
        {
            Console.WriteLine("Main update çalıştırıldı.");
        }
        public void Delete()
        {
            Console.WriteLine("Main delete çalıştırıldı.");
        }
    }
}
