using System;

namespace DesignPattern.referenceDesignCode
{
    // Subsystem A
    public class SubsystemA
    {
        public void OperationA()
        {
            Console.WriteLine("Subsystem A operation");
        }
    }

    // Subsystem B
    public class SubsystemB
    {
        public void OperationB()
        {
            Console.WriteLine("Subsystem B operation");
        }
    }

    // Subsystem C
    public class SubsystemC
    {
        public void OperationC()
        {
            Console.WriteLine("Subsystem C operation");
        }
    }

    // Facade class that simplifies subsystem usage
    public class Facade
    {
        private readonly SubsystemA _a;
        private readonly SubsystemB _b;
        private readonly SubsystemC _c;

        public Facade()
        {
            _a = new SubsystemA();
            _b = new SubsystemB();
            _c = new SubsystemC();
        }

        public void Operation()
        {
            _a.OperationA();
            _b.OperationB();
            _c.OperationC();
        }
    }

    // Runner class
    public static class FacadePattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Facade Pattern ===");

            Facade facade = new Facade();
            facade.Operation();
        }
    }
}

//using System;

//namespace DesignPatternsDotNetCore
//{
//    public class SubsystemA { public void OperationA() => Console.WriteLine("Subsystem A operation"); }
//    public class SubsystemB { public void OperationB() => Console.WriteLine("Subsystem B operation"); }
//    public class SubsystemC { public void OperationC() => Console.WriteLine("Subsystem C operation"); }

//    public class Facade
//    {
//        private readonly SubsystemA _a = new();
//        private readonly SubsystemB _b = new();
//        private readonly SubsystemC _c = new();

//        public void Operation()
//        {
//            _a.OperationA();
//            _b.OperationB();
//            _c.OperationC();
//        }
//    }

//    public static class FacadePattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Facade Pattern ===");
//            var facade = new Facade();
//            facade.Operation();
//        }
//    }
//}