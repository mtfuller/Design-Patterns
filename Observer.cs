using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary
{
    // Subject
    public interface Subject
    {
        void Notify();
        void Attach(Observer obj);
        void Remove(Observer obj);
    }

    // Concrete Subject
    public class ConcreteSubject : Subject
    {
        private readonly List<Observer> _objects;
        private string _message;
        public string Value
        {
            get { return _message; }
            set {
                _message = value;
                Notify();
            }
        }

        public ConcreteSubject()
        {
            _message = "This is my message!";
            _objects = new List<Observer>();
        }

        public void Attach(Observer obj)
        {
            _objects.Add(obj);
        }

        public void Notify()
        {
            foreach (var obj in _objects)
            {
                obj.Update(this);
            }
        }

        public void Remove(Observer obj)
        {
            _objects.Remove(obj);
        }
    }

    // Observer
    public interface Observer
    {
        void Update(Subject subject);
    }

    // Concrete Observer
    public class ConcreteObserver : Observer
    {
        private static int i = 0;
        private int num { get; }
        public ConcreteObserver()
        {
            num = i++;
        }
        public void Update(Subject subject)
        {
            Console.WriteLine($"Updating observer #{num} of Subject ({subject})");
        }
    }




}
