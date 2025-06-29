using System;

namespace DesignPatternsDotNetCore
{
    // Component interface
    public interface IComponentDecorator
    {
        void Operation();
    }

    // Concrete implementation of the component
    public class ConcreteComponent : IComponentDecorator
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteComponent operation");
        }
    }

    // Base Decorator class
    public class Decorator : IComponentDecorator
    {
        private readonly IComponentDecorator _component;

        public Decorator(IComponentDecorator component)
        {
            _component = component;
        }

        public virtual void Operation()
        {
            _component.Operation();
        }
    }

    // Concrete decorator that adds behavior
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(IComponentDecorator component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecorator added behavior");
        }
    }

    // Pattern runner
    public static class DecoratorPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Decorator Pattern ===");

            IComponentDecorator component = new ConcreteDecorator(new ConcreteComponent());
            component.Operation();
        }
    }
}

//using System;

//namespace DesignPatternsDotNetCore
//{
//    public interface IComponentDecorator
//    {
//        void Operation();
//    }

//    public class ConcreteComponent : IComponentDecorator
//    {
//        public void Operation() => Console.WriteLine("ConcreteComponent operation");
//    }

//    public class Decorator : IComponentDecorator
//    {
//        private readonly IComponentDecorator _component;
//        public Decorator(IComponentDecorator component) => _component = component;
//        public virtual void Operation()
//        {
//            _component.Operation();
//        }
//    }

//    public class ConcreteDecorator : Decorator
//    {
//        public ConcreteDecorator(IComponentDecorator component) : base(component) { }
//        public override void Operation()
//        {
//            base.Operation();
//            Console.WriteLine("ConcreteDecorator added behavior");
//        }
//    }

//    public static class DecoratorPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Decorator Pattern ===");
//            IComponentDecorator component = new ConcreteDecorator(new ConcreteComponent());
//            component.Operation();
//        }
//    }
//}