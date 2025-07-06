using System;

namespace DesignPattern.referenceDesignCode
{
    // Target interface that the client expects
    public interface ITarget
    {
        void Request();
    }

    // Existing class with a different interface (the Adaptee)
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }

    // Adapter class that makes Adaptee compatible with ITarget
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter()
        {
            // Initialize adaptee object
            _adaptee = new Adaptee();
        }

        // Implement the expected interface by calling adaptee's method
        public void Request()
        {
            // Internally use the adaptee's method
            _adaptee.SpecificRequest();
        }
    }

    // Client code that uses the adapter to interact with the adaptee
    public static class AdapterPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Adapter Pattern ===");

            // Create adapter object that implements ITarget
            ITarget target = new Adapter();

            // Call the method expected by the client
            target.Request();  // Internally calls Adaptee.SpecificRequest()
        }
    }
}

//using System;

//namespace DesignPatternsDotNetCore
//{
//    public interface ITarget
//    {
//        void Request();
//    }

//    public class Adaptee
//    {
//        public void SpecificRequest() => Console.WriteLine("Called SpecificRequest()");
//    }

//    public class Adapter : ITarget
//    {
//        private readonly Adaptee _adaptee = new Adaptee();
//        public void Request() => _adaptee.SpecificRequest();
//    }

//    public static class AdapterPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Adapter Pattern ===");
//            ITarget target = new Adapter();
//            target.Request();
//        }
//    }
//}