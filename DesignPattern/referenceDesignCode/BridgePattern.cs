using System;

namespace DesignPattern.referenceDesignCode
{
    // Implementor interface defines the implementation class interface
    public interface IImplementor
    {
        void OperationImpl();
    }

    // Concrete implementation class
    public class ConcreteImplementorA : IImplementor
    {
        public void OperationImpl()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }

    // Abstraction class holds a reference to the implementor interface
    public abstract class Abstraction
    {
        protected IImplementor implementor;

        // Constructor that accepts an implementor to bridge to
        protected Abstraction(IImplementor implementor)
        {
            this.implementor = implementor;
        }

        // Abstract method that must be implemented by concrete abstraction
        public abstract void Operation();
    }

    // Refined Abstraction implements the abstract method and delegates to implementor
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementor implementor) : base(implementor)
        {
        }

        public override void Operation()
        {
            // Delegate the call to the implementor's operation
            implementor.OperationImpl();
        }
    }

    // Client code
    public static class BridgePattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Bridge Pattern ===");

            // Create an abstraction instance and inject a concrete implementor
            Abstraction abstraction = new RefinedAbstraction(new ConcreteImplementorA());

            // Execute the operation which delegates to the implementor
            abstraction.Operation(); // Output: ConcreteImplementorA Operation
        }
    }
}

//using System;

//namespace DesignPatternsDotNetCore
//{
//    public interface IImplementor
//    {
//        void OperationImpl();
//    }

//    public class ConcreteImplementorA : IImplementor
//    {
//        public void OperationImpl() => Console.WriteLine("ConcreteImplementorA Operation");
//    }

//    public abstract class Abstraction
//    {
//        protected IImplementor implementor;
//        protected Abstraction(IImplementor implementor) => this.implementor = implementor;
//        public abstract void Operation();
//    }

//    public class RefinedAbstraction : Abstraction
//    {
//        public RefinedAbstraction(IImplementor implementor) : base(implementor) { }
//        public override void Operation() => implementor.OperationImpl();
//    }

//    public static class BridgePattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Bridge Pattern ===");
//            Abstraction abstraction = new RefinedAbstraction(new ConcreteImplementorA());
//            abstraction.Operation();
//        }
//    }
//}