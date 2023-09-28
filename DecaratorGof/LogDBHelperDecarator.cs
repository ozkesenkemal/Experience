using System;

namespace DecaratorGof
{
    public class LogDBHelperDecarator : DBHelperDecarator
    {
        public LogDBHelperDecarator(IDBHelper dBHelper) : base(dBHelper)
        {
        }

        public override void Get()
        {
            Console.WriteLine("Log kontrolü yapıldı.");
            base.Get();
        }
        public override void Save()
        {
            Console.WriteLine("Log kontrolü yapıldı.");
            base.Save();
        }
        public override void Update()
        {
            Console.WriteLine("Log kontrolü yapıldı.");
            base.Update();
        }
        public override void Delete()
        {
            Console.WriteLine("Log kontrolü yapıldı.");
            base.Delete();
        }
    }
}
