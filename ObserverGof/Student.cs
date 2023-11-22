using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ObserverGof
{
    public class Student
    {
        public readonly string Id;
        public readonly string Name;
        public readonly short Age;
        private bool _IsStudentExistsOnLesson;
        private readonly List<IObserver> _observerList;
        public bool IsStudentExistsOnLesson
        {
            get { return _IsStudentExistsOnLesson; }
            set
            {
                _IsStudentExistsOnLesson = true;
                Console.WriteLine($"{Age} yaşındaki öğrenci {Id} - {Name} dersi astı.");
                Notify();
            }
        }

        public Student(string name, int id, int age, bool isStudentExistsOnLesson)
        {
            _observerList = new List<IObserver>();
            Name = name;
            Age = Age;
            Id = Id;
            _IsStudentExistsOnLesson = isStudentExistsOnLesson;
            Console.WriteLine($"{Age} yaşındaki öğrenci {Id} - {Name} oluşturuldu ve derste.");
        }

        public void AddObserver(IObserver observer)
        {
            _observerList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observerList.Remove(observer);
        }

        private void Notify()
        {
            Parallel.ForEach(_observerList, observer =>
            {
                observer.UpdateObservers();
            });
        }
    }
}
