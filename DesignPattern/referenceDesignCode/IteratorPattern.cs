using System;
using System.Collections.Generic;

namespace DesignPattern.referenceDesignCode
{
    // Iterator Interface
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }

    // Aggregate Interface
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }

    // Concrete Aggregate
    public class ConcreteAggregate : IAggregate<string>
    {
        private List<string> _items;

        public ConcreteAggregate()
        {
            _items = new List<string>();
            _items.Add("A");
            _items.Add("B");
            _items.Add("C");
        }

        public IIterator<string> CreateIterator()
        {
            return new ConcreteIterator(_items);
        }
    }

    // Concrete Iterator
    public class ConcreteIterator : IIterator<string>
    {
        private List<string> _items;
        private int _position;

        public ConcreteIterator(List<string> items)
        {
            _items = items;
            _position = 0;
        }

        public bool HasNext()
        {
            return _position < _items.Count;
        }

        public string Next()
        {
            string item = _items[_position];
            _position++;
            return item;
        }
    }

    // Pattern Runner
    public static class IteratorPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Iterator Pattern ===");

            ConcreteAggregate aggregate = new ConcreteAggregate();
            IIterator<string> iterator = aggregate.CreateIterator();

            while (iterator.HasNext())
            {
                string item = iterator.Next();
                Console.WriteLine(item);
            }
        }
    }
}

//using System;
//using System.Collections.Generic;

//namespace DesignPatternsDotNetCore
//{
//    public interface IIterator<T>
//    {
//        bool HasNext();
//        T Next();
//    }

//    public interface IAggregate<T>
//    {
//        IIterator<T> CreateIterator();
//    }

//    public class ConcreteAggregate : IAggregate<string>
//    {
//        private readonly List<string> _items = new() { "A", "B", "C" };
//        public IIterator<string> CreateIterator() => new ConcreteIterator(_items);
//    }

//    public class ConcreteIterator : IIterator<string>
//    {
//        private readonly List<string> _items;
//        private int _position = 0;
//        public ConcreteIterator(List<string> items) => _items = items;
//        public bool HasNext() => _position < _items.Count;
//        public string Next() => _items[_position++];
//    }

//    public static class IteratorPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Iterator Pattern ===");
//            var aggregate = new ConcreteAggregate();
//            var iterator = aggregate.CreateIterator();
//            while (iterator.HasNext())
//                Console.WriteLine(iterator.Next());
//        }
//    }
//}