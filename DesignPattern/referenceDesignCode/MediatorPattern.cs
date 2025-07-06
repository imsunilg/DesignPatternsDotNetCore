using System;

namespace DesignPattern.referenceDesignCode
{
    // Abstract Colleague
    public abstract class Colleague
    {
        protected Mediator _mediator;

        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }
    }

    // Concrete Colleague 1
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague1 received: " + message);
        }
    }

    // Concrete Colleague 2
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague2 received: " + message);
        }
    }

    // Abstract Mediator
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }

    // Concrete Mediator
    public class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 _colleague1;
        private ConcreteColleague2 _colleague2;

        public ConcreteColleague1 Colleague1
        {
            get { return _colleague1; }
            set { _colleague1 = value; }
        }

        public ConcreteColleague2 Colleague2
        {
            get { return _colleague2; }
            set { _colleague2 = value; }
        }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == _colleague1)
            {
                _colleague2.Notify(message);
            }
            else
            {
                _colleague1.Notify(message);
            }
        }
    }

    // Pattern Executor
    public static class MediatorPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Mediator Pattern ===");

            ConcreteMediator mediator = new ConcreteMediator();

            ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;

            colleague1.Send("Hello from Colleague1");
            colleague2.Send("Hello from Colleague2");
        }
    }
}

//using System;

//namespace DesignPatternsDotNetCore
//{
//    public abstract class Colleague
//    {
//        protected Mediator _mediator;
//        public Colleague(Mediator mediator) => _mediator = mediator;
//    }

//    public class ConcreteColleague1 : Colleague
//    {
//        public ConcreteColleague1(Mediator mediator) : base(mediator) { }
//        public void Send(string message) => _mediator.Send(message, this);
//        public void Notify(string message) => Console.WriteLine("Colleague1 received: " + message);
//    }

//    public class ConcreteColleague2 : Colleague
//    {
//        public ConcreteColleague2(Mediator mediator) : base(mediator) { }
//        public void Send(string message) => _mediator.Send(message, this);
//        public void Notify(string message) => Console.WriteLine("Colleague2 received: " + message);
//    }

//    public abstract class Mediator
//    {
//        public abstract void Send(string message, Colleague colleague);
//    }

//    public class ConcreteMediator : Mediator
//    {
//        public ConcreteColleague1 Colleague1 { get; set; }
//        public ConcreteColleague2 Colleague2 { get; set; }

//        public override void Send(string message, Colleague colleague)
//        {
//            if (colleague == Colleague1)
//                Colleague2.Notify(message);
//            else
//                Colleague1.Notify(message);
//        }
//    }

//    public static class MediatorPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Mediator Pattern ===");
//            var mediator = new ConcreteMediator();
//            var c1 = new ConcreteColleague1(mediator);
//            var c2 = new ConcreteColleague2(mediator);
//            mediator.Colleague1 = c1;
//            mediator.Colleague2 = c2;

//            c1.Send("Hello from Colleague1");
//            c2.Send("Hello from Colleague2");
//        }
//    }
//}