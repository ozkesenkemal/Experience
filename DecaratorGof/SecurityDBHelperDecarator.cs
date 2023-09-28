using System;

namespace DecaratorGof
{
    public class SecurityDBHelperDecarator : DBHelperDecarator
    {
        public SecurityDBHelperDecarator(IDBHelper dBHelper) : base(dBHelper)
        {
        }

        public override void Get()
        {
            Console.WriteLine("Güvenlik kontrolü yapıldı.");
            base.Get();
        }
        public override void Save()
        {
            Console.WriteLine("Güvenlik kontrolü yapıldı.");
            base.Save();
        }
        public override void Update()
        {
            Console.WriteLine("Güvenlik kontrolü yapıldı.");
            base.Update();
        }
        public override void Delete()
        {
            Console.WriteLine("Güvenlik kontrolü yapıldı.");
            base.Delete();
        }
    }
}
