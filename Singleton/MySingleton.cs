namespace Singleton
{
    public class MySingleton
    {
        private MySingleton()
        { 
        }

        private static MySingleton? _singletonObj;
        private static readonly object _myLockObj = new object();

        public static MySingleton GetMySingletonObj()
        {
            lock (_myLockObj) // disable multithread requests take different objects
            {
                if (_singletonObj == null)
                {
                    _singletonObj = new MySingleton();
                }
            }

            return _singletonObj;
        }
    }
}