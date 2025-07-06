using System;

namespace DesignPattern.referenceDesignCode
{
    // The Singleton class ensures that only one instance of itself is created.
    public class Singleton
    {
        // Static variable to hold the single instance of the class
        private static Singleton _instance;

        // Lock object to make the instance thread-safe
        private static readonly object _lock = new object();

        // Private constructor ensures that the class cannot be instantiated from outside
        private Singleton()
        {
            Console.WriteLine("Singleton Constructor: Creating instance.");
        }

        // Public static property to get the single instance of the class
        public static Singleton Instance
        {
            get
            {
                // Lock ensures that only one thread can access the following block at a time
                lock (_lock)
                {
                    // If instance is null, create it
                    if (_instance == null)
                    {
                        Console.WriteLine("Instance is null. Creating new Singleton instance...");
                        _instance = new Singleton();
                    }
                    else
                    {
                        Console.WriteLine("Returning existing Singleton instance...");
                    }

                    return _instance;
                }
            }
        }

        // Example method to demonstrate functionality
        public void ShowMessage()
        {
            Console.WriteLine("Singleton instance invoked");
        }
    }

    // This class is responsible for executing the Singleton pattern demo
    public static class SingletonPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Singleton Pattern ===");

            // First call - should create the Singleton instance
            var instance1 = Singleton.Instance;
            instance1.ShowMessage();

            // Second call - should return the same instance
            var instance2 = Singleton.Instance;
            instance2.ShowMessage();

            // Check if both instances are the same (expected: True)
            Console.WriteLine($"Are both instances same? {ReferenceEquals(instance1, instance2)}");
        }
    }
}

//using System;

//namespace DesignPatternsDotNetCore
//{
//    public class Singleton
//    {
//        private static Singleton _instance;
//        private static readonly object _lock = new object();

//        private Singleton() { }

//        public static Singleton Instance
//        {
//            get
//            {
//                lock (_lock)
//                {
//                    return _instance ??= new Singleton();
//                }
//            }
//        }

//        public void ShowMessage() => Console.WriteLine("Singleton instance invoked");
//    }

//    public static class SingletonPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Singleton Pattern ===");
//            Singleton.Instance.ShowMessage();
//        }
//    }
//}