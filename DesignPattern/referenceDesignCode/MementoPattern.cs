using System;

namespace DesignPattern.referenceDesignCode
{
    // Memento class to store state
    public class Memento
    {
        private string _state;

        public Memento(string state)
        {
            _state = state;
        }

        public string GetState()
        {
            return _state;
        }
    }

    // Originator class that creates and restores mementos
    public class Originator
    {
        private string _state;

        public void SetState(string state)
        {
            _state = state;
        }

        public string GetState()
        {
            return _state;
        }

        public Memento SaveState()
        {
            return new Memento(_state);
        }

        public void RestoreState(Memento memento)
        {
            _state = memento.GetState();
        }
    }

    // Caretaker class that holds the memento
    public class Caretaker
    {
        private Memento _memento;

        public void SetMemento(Memento memento)
        {
            _memento = memento;
        }

        public Memento GetMemento()
        {
            return _memento;
        }
    }

    // Pattern Executor
    public static class MementoPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Memento Pattern ===");

            Originator originator = new Originator();
            originator.SetState("State1");

            Caretaker caretaker = new Caretaker();
            caretaker.SetMemento(originator.SaveState());

            originator.SetState("State2");

            originator.RestoreState(caretaker.GetMemento());

            Console.WriteLine("Restored state: " + originator.GetState());
        }
    }
}

//using System;

//namespace DesignPatternsDotNetCore
//{
//    public class Memento
//    {
//        public string State { get; }
//        public Memento(string state) => State = state;
//    }

//    public class Originator
//    {
//        public string State { get; set; }
//        public Memento SaveState() => new Memento(State);
//        public void RestoreState(Memento memento) => State = memento.State;
//    }

//    public class Caretaker
//    {
//        public Memento Memento { get; set; }
//    }

//    public static class MementoPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Memento Pattern ===");
//            var originator = new Originator { State = "State1" };
//            var caretaker = new Caretaker { Memento = originator.SaveState() };
//            originator.State = "State2";
//            originator.RestoreState(caretaker.Memento);
//            Console.WriteLine("Restored state: " + originator.State);
//        }
//    }
//}