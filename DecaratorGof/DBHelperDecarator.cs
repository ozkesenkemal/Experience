namespace DecaratorGof
{
    public class DBHelperDecarator : IDBHelper
    {
        IDBHelper _dBHelper;
        public DBHelperDecarator(IDBHelper dBHelper)
        {
            _dBHelper = dBHelper;
        }
        public virtual void Delete()
        {
            _dBHelper.Delete();
        }

        public virtual void Get()
        {
            _dBHelper.Get();
        }

        public virtual void Save()
        {
            _dBHelper.Save();
        }

        public virtual void Update()
        {
            _dBHelper.Update();
        }
    }
}
