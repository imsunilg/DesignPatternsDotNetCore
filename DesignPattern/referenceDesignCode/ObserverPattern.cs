using System;
using System.Collections.Generic;

namespace DesignPattern.referenceDesignCode
{
    // Observer interface
    public interface IObserver
    {
        void Update(string message);
    }

    // Subject interface
    public interface ISubjectObserver
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string message);
    }

    // Concrete Subject
    public class ConcreteSubject : ISubjectObserver
    {
        private readonly List<IObserver> _observers;

        public ConcreteSubject()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(message);
            }
        }
    }

    // Concrete Observer
    public class ConcreteObserver : IObserver
    {
        private string _name;

        public ConcreteObserver(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine(_name + " received message: " + message);
        }
    }

    // Pattern Executor
    public static class ObserverPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Observer Pattern ===");

            ConcreteSubject subject = new ConcreteSubject();

            ConcreteObserver observer1 = new ConcreteObserver("Observer1");
            ConcreteObserver observer2 = new ConcreteObserver("Observer2");

            subject.Attach(observer1);
            subject.Attach(observer2);

            subject.Notify("Hello Observers!");
        }
    }
}

//using System;
//using System.Collections.Generic;

//namespace DesignPatternsDotNetCore
//{
//    public interface IObserver
//    {
//        void Update(string message);
//    }

//    // Renamed the conflicting interface to avoid CS0101 error
//    public interface ISubjectObserver
//    {
//        void Attach(IObserver observer);
//        void Detach(IObserver observer);
//        void Notify(string message);
//    }

//    public class ConcreteSubject : ISubjectObserver
//    {
//        private readonly List<IObserver> _observers = new();

//        public void Attach(IObserver observer) => _observers.Add(observer);
//        public void Detach(IObserver observer) => _observers.Remove(observer);
//        public void Notify(string message)
//        {
//            foreach (var observer in _observers)
//                observer.Update(message);
//        }
//    }

//    public class ConcreteObserver : IObserver
//    {
//        private readonly string _name;
//        public ConcreteObserver(string name) => _name = name;
//        public void Update(string message) => Console.WriteLine($"{_name} received message: {message}");
//    }

//    public static class ObserverPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Observer Pattern ===");
//            var subject = new ConcreteSubject();
//            var obs1 = new ConcreteObserver("Observer1");
//            var obs2 = new ConcreteObserver("Observer2");
//            subject.Attach(obs1);
//            subject.Attach(obs2);
//            subject.Notify("Hello Observers!");
//        }
//    }
//}