using System;

namespace DesignPatternsDotNetCore
{
    // Product class that is being constructed
    public class Product
    {
        public string PartA { get; set; }
        public string PartB { get; set; }

        public void Show()
        {
            Console.WriteLine($"Product with {PartA} and {PartB}");
        }
    }

    // Builder interface declares methods for building parts of a product
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetResult();
    }

    // Concrete implementation of builder
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public void BuildPartA()
        {
            _product.PartA = "PartA"; // Assign PartA
        }

        public void BuildPartB()
        {
            _product.PartB = "PartB"; // Assign PartB
        }

        public Product GetResult()
        {
            return _product; // Return the fully built product
        }
    }

    // Director class controls the building process using a builder
    public class Director
    {
        public void Construct(IBuilder builder)
        {
            // Construct the product step by step
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    // Client code to execute the builder pattern
    public static class BuilderPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Builder Pattern ===");

            // Create a builder instance
            IBuilder builder = new ConcreteBuilder();

            // Create a director that uses the builder
            Director director = new Director();

            // Director controls the building steps
            director.Construct(builder);

            // Get the finished product from the builder
            Product product = builder.GetResult();

            // Display the product details
            product.Show(); // Output: Product with PartA and PartB
        }
    }
}

//using System;

//namespace DesignPatternsDotNetCore
//{
//    public class Product
//    {
//        public string PartA { get; set; }
//        public string PartB { get; set; }
//        public void Show() => Console.WriteLine($"Product with {PartA} and {PartB}");
//    }

//    public interface IBuilder
//    {
//        void BuildPartA();
//        void BuildPartB();
//        Product GetResult();
//    }

//    public class ConcreteBuilder : IBuilder
//    {
//        private Product _product = new Product();
//        public void BuildPartA() => _product.PartA = "PartA";
//        public void BuildPartB() => _product.PartB = "PartB";
//        public Product GetResult() => _product;
//    }

//    public class Director
//    {
//        public void Construct(IBuilder builder)
//        {
//            builder.BuildPartA();
//            builder.BuildPartB();
//        }
//    }

//    public static class BuilderPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Builder Pattern ===");
//            IBuilder builder = new ConcreteBuilder();
//            var director = new Director();
//            director.Construct(builder);
//            Product product = builder.GetResult();
//            product.Show();
//        }
//    }
//}