using System;

namespace DesignPattern.referenceDesignCode
{
    // Product Interface
    public interface IProduct
    {
        void Show();
    }

    // Concrete Product A
    public class ProductA : IProduct
    {
        public void Show()
        {
            Console.WriteLine("Product A");
        }
    }

    // Concrete Product B
    public class ProductB : IProduct
    {
        public void Show()
        {
            Console.WriteLine("Product B");
        }
    }

    // Factory Class
    public class Factory
    {
        public IProduct CreateProduct(string type)
        {
            if (type == "A")
            {
                return new ProductA();
            }
            else if (type == "B")
            {
                return new ProductB();
            }
            else
            {
                throw new ArgumentException("Invalid type");
            }
        }
    }

    // Runner
    public static class FactoryPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Factory Pattern ===");

            Factory factory = new Factory();
            IProduct product = factory.CreateProduct("A");
            product.Show();
        }
    }
}

//using System;

//namespace DesignPatternsDotNetCore
//{
//    public interface IProduct { void Show(); }

//    public class ProductA : IProduct { public void Show() => Console.WriteLine("Product A"); }
//    public class ProductB : IProduct { public void Show() => Console.WriteLine("Product B"); }

//    public class Factory
//    {
//        public IProduct CreateProduct(string type) => type switch
//        {
//            "A" => new ProductA(),
//            "B" => new ProductB(),
//            _ => throw new ArgumentException("Invalid type")
//        };
//    }

//    public static class FactoryPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Factory Pattern ===");
//            var factory = new Factory();
//            IProduct product = factory.CreateProduct("A");
//            product.Show();
//        }
//    }
//}