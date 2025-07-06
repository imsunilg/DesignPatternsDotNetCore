using System;

namespace DesignPattern.referenceDesignCode
{
    // Abstract Handler declares interface for handling requests
    public abstract class Handler
    {
        protected Handler _next;

        // Set the next handler in the chain
        public void SetNext(Handler next)
        {
            _next = next;
        }

        // Abstract method to handle request
        public abstract void HandleRequest(int request);
    }

    // ConcreteHandler1 handles requests less than 10
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request < 10)
            {
                Console.WriteLine("Handled by Handler1");
            }
            else
            {
                if (_next != null)
                {
                    _next.HandleRequest(request); // Pass to next handler
                }
            }
        }
    }

    // ConcreteHandler2 handles requests less than 20
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request < 20)
            {
                Console.WriteLine("Handled by Handler2");
            }
            else
            {
                Console.WriteLine("Request not handled");
            }
        }
    }

    // Main execution class for the pattern
    public static class ChainOfResponsibilityPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Chain of Responsibility Pattern ===");

            // Create handlers
            ConcreteHandler1 handler1 = new ConcreteHandler1();
            ConcreteHandler2 handler2 = new ConcreteHandler2();

            // Set the chain of handlers
            handler1.SetNext(handler2);

            // Send requests into the chain
            handler1.HandleRequest(5);   // Handled by Handler1
            handler1.HandleRequest(15);  // Handled by Handler2
            handler1.HandleRequest(25);  // Request not handled
        }
    }
}

//using System;

//namespace DesignPatternsDotNetCore
//{
//    public abstract class Handler
//    {
//        protected Handler _next;
//        public void SetNext(Handler next) => _next = next;
//        public abstract void HandleRequest(int request);
//    }

//    public class ConcreteHandler1 : Handler
//    {
//        public override void HandleRequest(int request)
//        {
//            if (request < 10)
//                Console.WriteLine("Handled by Handler1");
//            else
//                _next?.HandleRequest(request);
//        }
//    }

//    public class ConcreteHandler2 : Handler
//    {
//        public override void HandleRequest(int request)
//        {
//            if (request < 20)
//                Console.WriteLine("Handled by Handler2");
//            else
//                Console.WriteLine("Request not handled");
//        }
//    }

//    public static class ChainOfResponsibilityPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Chain of Responsibility Pattern ===");
//            var handler1 = new ConcreteHandler1();
//            var handler2 = new ConcreteHandler2();
//            handler1.SetNext(handler2);

//            handler1.HandleRequest(5);
//            handler1.HandleRequest(15);
//            handler1.HandleRequest(25);
//        }
//    }
//}