using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.selfCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DesignPattern.selfCode
    {
        // Eager Initialization (Thread-safe by nature)
        public class MySingleton_Eager
        {
            private MySingleton_Eager()
            {
                Console.WriteLine("New _instance object created");
            }

            private static readonly MySingleton_Eager _instance = new MySingleton_Eager();
            public static MySingleton_Eager Instance()
            {
                Console.WriteLine("Old _instance object returned");
                return _instance;
            }

            public void ShowMessage()
            {
                Console.WriteLine("MySingleton_Eager instance invoked");
            }
        }

        // Using Lazy<T> (Recommended for simplicity and thread-safety)
        public class MySingleton_Lazy
        {
            private MySingleton_Lazy() { }

            private static readonly Lazy<MySingleton_Lazy> _lazyInstance = new Lazy<MySingleton_Lazy>(() =>
            {
                Console.WriteLine("New _instance object created");
                return new MySingleton_Lazy();
            });

            public static MySingleton_Lazy Instance()
            {
                Console.WriteLine("Old _instance object returned");
                return _lazyInstance.Value;
            }

            public void ShowMessage()
            {
                Console.WriteLine("MySingleton_Lazy instance invoked");
            }
        }

        // Thread-Safe with lock (Lazy Initialization)
        public class MySingleton_ThreadSafe
        {
            private MySingleton_ThreadSafe() { }

            private static MySingleton_ThreadSafe _instance;
            private static readonly object _lock = new object();

            public static MySingleton_ThreadSafe Instance()
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            Console.WriteLine("New _instance object created");
                            _instance = new MySingleton_ThreadSafe();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Old _instance object returned");
                }

                return _instance;
            }

            public void ShowMessage()
            {
                Console.WriteLine("MySingleton_ThreadSafe instance invoked");
            }
        }

        // Singleton without thread-safety
        public class MySingleton_NonThreadSafe
        {
            private MySingleton_NonThreadSafe() { }

            private static MySingleton_NonThreadSafe _instance;
            public static MySingleton_NonThreadSafe Instance()
            {
                if (_instance is null)
                {
                    Console.WriteLine("New _instance object created");
                    return _instance = new MySingleton_NonThreadSafe();
                }
                else
                {
                    Console.WriteLine("Old _instance object returned");
                    return _instance;
                }
            }

            public void ShowMessage()
            {
                Console.WriteLine("MySingleton_NonThreadSafe instance invoked");
            }
        }
    }

}
