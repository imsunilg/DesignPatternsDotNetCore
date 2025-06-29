using System;

namespace DesignPatternsDotNetCore
{
    // Strategy Interface
    public interface IStrategy
    {
        void Execute();
    }

    // Concrete Strategy A
    public class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Strategy A executed");
        }
    }

    // Concrete Strategy B
    public class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Strategy B executed");
        }
    }

    // Context class
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            _strategy.Execute();
        }
    }

    // Pattern Executor
    public static class StrategyPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Strategy Pattern ===");

            Context context = new Context(new ConcreteStrategyA());
            context.ExecuteStrategy();

            context.SetStrategy(new ConcreteStrategyB());
            context.ExecuteStrategy();
        }
    }
}

//using System;

//namespace DesignPatternsDotNetCore
//{
//    public interface IStrategy
//    {
//        void Execute();
//    }

//    public class ConcreteStrategyA : IStrategy
//    {
//        public void Execute() => Console.WriteLine("Strategy A executed");
//    }

//    public class ConcreteStrategyB : IStrategy
//    {
//        public void Execute() => Console.WriteLine("Strategy B executed");
//    }

//    public class Context
//    {
//        private IStrategy _strategy;
//        public Context(IStrategy strategy) => _strategy = strategy;
//        public void SetStrategy(IStrategy strategy) => _strategy = strategy;
//        public void ExecuteStrategy() => _strategy.Execute();
//    }

//    public static class StrategyPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Strategy Pattern ===");
//            var context = new Context(new ConcreteStrategyA());
//            context.ExecuteStrategy();
//            context.SetStrategy(new ConcreteStrategyB());
//            context.ExecuteStrategy();
//        }
//    }
//}