using System;

namespace DesignPatternsDotNetCore
{
    // Abstract Prototype
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    // Concrete Prototype
    public class ConcretePrototype : Prototype
    {
        private string _field;

        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }

        public void Show()
        {
            Console.WriteLine("Cloned object with field: " + _field);
        }
    }

    // Pattern Executor
    public static class PrototypePattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Prototype Pattern ===");

            ConcretePrototype original = new ConcretePrototype();
            original.Field = "Original";

            Prototype clonedObject = original.Clone();
            ConcretePrototype clone = (ConcretePrototype)clonedObject;

            clone.Show();
        }
    }
}

//using System;

//namespace DesignPatternsDotNetCore
//{
//    public abstract class Prototype
//    {
//        public abstract Prototype Clone();
//    }

//    public class ConcretePrototype : Prototype
//    {
//        public string Field { get; set; }
//        public override Prototype Clone() => (Prototype)this.MemberwiseClone();
//        public void Show() => Console.WriteLine($"Cloned object with field: {Field}");
//    }

//    public static class PrototypePattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Prototype Pattern ===");
//            var original = new ConcretePrototype { Field = "Original" };
//            var clone = original.Clone() as ConcretePrototype;
//            clone.Show();
//        }
//    }
//}