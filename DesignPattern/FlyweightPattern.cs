using System;
using System.Collections.Generic;

namespace DesignPatternsDotNetCore
{
    // Flyweight class
    public class Flyweight
    {
        private string _intrinsicState;

        public Flyweight(string intrinsicState)
        {
            _intrinsicState = intrinsicState;
        }

        public void Operation(string extrinsicState)
        {
            Console.WriteLine("Flyweight with " + _intrinsicState + " and " + extrinsicState);
        }
    }

    // Flyweight Factory
    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> _flyweights;

        public FlyweightFactory()
        {
            _flyweights = new Dictionary<string, Flyweight>();
        }

        public Flyweight GetFlyweight(string key)
        {
            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new Flyweight(key);
            }

            return _flyweights[key];
        }
    }

    // Runner class
    public static class FlyweightPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Flyweight Pattern ===");

            FlyweightFactory factory = new FlyweightFactory();

            Flyweight flyweight1 = factory.GetFlyweight("A");
            flyweight1.Operation("state1");

            Flyweight flyweight2 = factory.GetFlyweight("A");
            flyweight2.Operation("state2");

            Console.WriteLine("Same instance: " + ReferenceEquals(flyweight1, flyweight2));
        }
    }
}

//using System;
//using System.Collections.Generic;

//namespace DesignPatternsDotNetCore
//{
//    public class Flyweight
//    {
//        private readonly string _intrinsicState;
//        public Flyweight(string intrinsicState) => _intrinsicState = intrinsicState;
//        public void Operation(string extrinsicState) =>
//            Console.WriteLine($"Flyweight with {_intrinsicState} and {extrinsicState}");
//    }

//    public class FlyweightFactory
//    {
//        private readonly Dictionary<string, Flyweight> _flyweights = new();
//        public Flyweight GetFlyweight(string key)
//        {
//            if (!_flyweights.ContainsKey(key))
//                _flyweights[key] = new Flyweight(key);
//            return _flyweights[key];
//        }
//    }

//    public static class FlyweightPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Flyweight Pattern ===");
//            var factory = new FlyweightFactory();
//            var flyweight1 = factory.GetFlyweight("A");
//            flyweight1.Operation("state1");

//            var flyweight2 = factory.GetFlyweight("A");
//            flyweight2.Operation("state2");

//            Console.WriteLine($"Same instance: {ReferenceEquals(flyweight1, flyweight2)}");
//        }
//    }
//}