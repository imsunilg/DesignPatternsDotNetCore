using System;
using System.Collections.Generic;

namespace DesignPattern.referenceDesignCode
{
    public interface IComponent
    {
        void Operation();
    }

    public class Leaf : IComponent
    {
        public void Operation() => Console.WriteLine("Leaf operation");
    }

    public class Composite : IComponent
    {
        private readonly List<IComponent> _children = new();
        public void Add(IComponent component) => _children.Add(component);
        public void Operation()
        {
            Console.WriteLine("Composite operation");
            foreach (var child in _children)
                child.Operation();
        }
    }

    public static class CompositePattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Composite Pattern ===");
            var root = new Composite();
            root.Add(new Leaf());
            root.Add(new Leaf());
            root.Operation();
        }
    }
}
//using System;
//using System.Collections.Generic;

//namespace DesignPatternsDotNetCore
//{
//    public interface IComponent
//    {
//        void Operation();
//    }

//    public class Leaf : IComponent
//    {
//        public void Operation() => Console.WriteLine("Leaf operation");
//    }

//    public class Composite : IComponent
//    {
//        private readonly List<IComponent> _children = new();
//        public void Add(IComponent component) => _children.Add(component);
//        public void Operation()
//        {
//            Console.WriteLine("Composite operation");
//            foreach (var child in _children)
//                child.Operation();
//        }
//    }

//    public static class CompositePattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Composite Pattern ===");
//            var root = new Composite();
//            root.Add(new Leaf());
//            root.Add(new Leaf());
//            root.Operation();
//        }
//    }
//}