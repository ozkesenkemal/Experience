using System;

namespace ObserverGof
{
    public class MotherObserver : IObserver
    {
        public void UpdateObservers()
        {
            Console.WriteLine("Öğrencinin dersi astığından Annesinin haberi oldu!");
        }
    }
}