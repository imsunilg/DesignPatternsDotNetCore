using System;

namespace DesignPattern.referenceDesignCode
{
    // Visitor Interface
    public interface IVisitor
    {
        void Visit(ElementA element);
        void Visit(ElementB element);
    }

    // Element Interface
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    // Concrete Element A
    public class ElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    // Concrete Element B
    public class ElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    // Concrete Visitor Implementation
    public class ConcreteVisitor : IVisitor
    {
        public void Visit(ElementA element)
        {
            Console.WriteLine("Visited ElementA");
        }

        public void Visit(ElementB element)
        {
            Console.WriteLine("Visited ElementB");
        }
    }

    // Executor Class
    public static class VisitorPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Visitor Pattern ===");

            IElement[] elements = new IElement[]
            {
                new ElementA(),
                new ElementB()
            };

            ConcreteVisitor visitor = new ConcreteVisitor();

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i].Accept(visitor);
            }
        }
    }
}

//using System;

//namespace DesignPatternsDotNetCore
//{
//    public interface IVisitor
//    {
//        void Visit(ElementA element);
//        void Visit(ElementB element);
//    }

//    public interface IElement
//    {
//        void Accept(IVisitor visitor);
//    }

//    public class ElementA : IElement
//    {
//        public void Accept(IVisitor visitor) => visitor.Visit(this);
//    }

//    public class ElementB : IElement
//    {
//        public void Accept(IVisitor visitor) => visitor.Visit(this);
//    }

//    public class ConcreteVisitor : IVisitor
//    {
//        public void Visit(ElementA element) => Console.WriteLine("Visited ElementA");
//        public void Visit(ElementB element) => Console.WriteLine("Visited ElementB");
//    }

//    public static class VisitorPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Visitor Pattern ===");
//            IElement[] elements = { new ElementA(), new ElementB() };
//            var visitor = new ConcreteVisitor();
//            foreach (var element in elements)
//                element.Accept(visitor);
//        }
//    }
//}