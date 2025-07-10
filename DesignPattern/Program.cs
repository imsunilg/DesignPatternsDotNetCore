using DesignPattern.referenceDesignCode;
using DesignPattern.selfCode;
using DesignPattern.selfCode.DesignPattern.selfCode;
using System;

namespace DesignPatternsDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Design Patterns Examples in .NET Core");

            #region factory Example
            /*
            Waiter objwaiter = new Waiter();
            IPizza pizza= objwaiter.GetPizza("veg");
            Console.WriteLine(pizza.Eat());

            Waiter objwaiter2 = new Waiter();
            objwaiter2.GetPizza("non-veg");
            IPizza pizza2 = objwaiter.GetPizza("non-veg");
            Console.WriteLine(pizza2.Eat());

            Console.WriteLine($"obj1: {objwaiter.GetHashCode()}");
            Console.WriteLine($"obj2: {objwaiter2.GetHashCode()}");
            

            var factoryObj=   IInsurancePolicyFactory.CreatePolicy("motor");
            Console.WriteLine(factoryObj.GetPolicyDetails()); 

            var factoryObj = IInsurancePolicyFactory.CreatePolicy("health");
            Console.WriteLine(factoryObj.GetPolicyDetails());
            */
            #endregion factory Example

            #region selfCode Singleton Example
            /*
            var s1 = MySingleton_Eager.Instance();
            s1.ShowMessage();

            var s2 = MySingleton_Lazy.Instance();
            s2.ShowMessage();

            var s3 = MySingleton_ThreadSafe.Instance();
            s3.ShowMessage();

            var s4 = MySingleton_NonThreadSafe.Instance();
            s4.ShowMessage();

            Console.WriteLine($"obj1: {s1.GetHashCode()}");
            Console.WriteLine($"obj2: {s2.GetHashCode()}");
            Console.WriteLine($"obj3: {s3.GetHashCode()}");
            Console.WriteLine($"obj4: {s4.GetHashCode()}");
            */
            #endregion selfCode Singleton Example

            #region Design Patterns Execution
            /* 
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

            */
            #endregion Design Patterns Execution


        }
    }
}