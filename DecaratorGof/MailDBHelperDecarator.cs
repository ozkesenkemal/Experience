using System;

namespace DecaratorGof
{
    public class MailDBHelperDecarator : DBHelperDecarator
    {
        public MailDBHelperDecarator(IDBHelper dBHelper) : base(dBHelper)
        {
        }

        public override void Get()
        {
            Console.WriteLine("Mail kontrolü yapıldı.");
            base.Get();
        }
        public override void Save()
        {
            Console.WriteLine("Mail kontrolü yapıldı.");
            base.Save();
        }
        public override void Update()
        {
            Console.WriteLine("Mail kontrolü yapıldı.");
            base.Update();
        }
        public override void Delete()
        {
            Console.WriteLine("Mail kontrolü yapıldı.");
            base.Delete();
        }
    }
}
