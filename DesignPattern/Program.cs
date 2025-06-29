using System;

namespace DesignPatternsDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns Examples in .NET Core");

            // Call each design pattern method here (examples below)

            ////Creational Design Patterns Execution
            Console.WriteLine("==============Creational Design Patterns Execution==============");
            SingletonPattern.Execute();
            FactoryPattern.Execute();
            AbstractFactoryPattern.Execute();
            BuilderPattern.Execute();
            PrototypePattern.Execute();
            Console.WriteLine("==============End of Creational Design Patterns==============");
            //// Structural Design Patterns Execution

            Console.WriteLine("==============Structural Design Patterns Execution==============");
            AdapterPattern.Execute();
            BridgePattern.Execute();
            CompositePattern.Execute();
            DecoratorPattern.Execute();
            FacadePattern.Execute();
            FlyweightPattern.Execute();
            ProxyPattern.Execute();
            Console.WriteLine("==============End of Structural Design Patterns==============");
            //// Behavioral Design Patterns Execution 
            Console.WriteLine("==============Behavioral Design Patterns Execution==============");
            ChainOfResponsibilityPattern.Execute();
            CommandPattern.Execute();
            InterpreterPattern.Execute();
            IteratorPattern.Execute();
            MediatorPattern.Execute();
            MementoPattern.Execute();
            ObserverPattern.Execute();
            StatePattern.Execute();
            StrategyPattern.Execute();
            TemplatePattern.Execute();
            VisitorPattern.Execute();
            Console.WriteLine("==============End of Behavioral Design Patterns==============");
        }
    }
}