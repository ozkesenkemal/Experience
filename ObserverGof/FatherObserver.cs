using System;

namespace ObserverGof
{
    public class FatherObserver : IObserver
    {
        public void UpdateObservers()
        {
            Console.WriteLine("Öğrencinin dersi astığından Babasının haberi oldu!");
        }
    }
}
