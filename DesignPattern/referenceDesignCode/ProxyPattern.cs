using System;

namespace DesignPattern.referenceDesignCode
{
    // Subject Interface
    public interface ISubject
    {
        void Request();
    }

    // Real Subject
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling request.");
        }
    }

    // Proxy
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public void Request()
        {
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }

            Console.WriteLine("Proxy: Logging and controlling access.");
            _realSubject.Request();
        }
    }

    // Pattern Executor
    public static class ProxyPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Proxy Pattern ===");

            ISubject proxy = new Proxy();
            proxy.Request();
        }
    }
}

//using System;

//namespace DesignPatternsDotNetCore
//{
//    public interface ISubject
//    {
//        void Request();
//    }

//    public class RealSubject : ISubject
//    {
//        public void Request() => Console.WriteLine("RealSubject: Handling request.");
//    }

//    public class Proxy : ISubject
//    {
//        private RealSubject _realSubject;
//        public void Request()
//        {
//            if (_realSubject == null)
//                _realSubject = new RealSubject();
//            Console.WriteLine("Proxy: Logging and controlling access.");
//            _realSubject.Request();
//        }
//    }

//    public static class ProxyPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Proxy Pattern ===");
//            ISubject proxy = new Proxy();
//            proxy.Request();
//        }
//    }
//}