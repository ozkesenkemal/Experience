using System;

namespace ObserverGof
{
    public class TeacherObserver : IObserver
    {
        public void UpdateObservers()
        {
            Console.WriteLine("Öğrencinin dersi astığından Öğretmenin haberi oldu!");
        }
    }
}