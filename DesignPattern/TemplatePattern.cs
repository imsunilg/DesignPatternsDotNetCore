using System;

namespace DesignPatternsDotNetCore
{
    // Abstract Template Class
    public abstract class Template
    {
        public void Execute()
        {
            Step1();
            Step2();
            Hook(); // Optional
        }

        protected abstract void Step1();
        protected abstract void Step2();

        // Optional step (hook)
        protected virtual void Hook()
        {
            // Default implementation: do nothing
        }
    }

    // Concrete Implementation of Template
    public class ConcreteTemplate : Template
    {
        protected override void Step1()
        {
            Console.WriteLine("Step1 executed");
        }

        protected override void Step2()
        {
            Console.WriteLine("Step2 executed");
        }

        protected override void Hook()
        {
            Console.WriteLine("Optional hook executed");
        }
    }

    // Executor Class
    public static class TemplatePattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Template Pattern ===");

            ConcreteTemplate template = new ConcreteTemplate();
            template.Execute();
        }
    }
}

//using System;

//namespace DesignPatternsDotNetCore
//{
//    public abstract class Template
//    {
//        public void Execute()
//        {
//            Step1();
//            Step2();
//            Hook();
//        }

//        protected abstract void Step1();
//        protected abstract void Step2();
//        protected virtual void Hook() { }
//    }

//    public class ConcreteTemplate : Template
//    {
//        protected override void Step1() => Console.WriteLine("Step1 executed");
//        protected override void Step2() => Console.WriteLine("Step2 executed");
//        protected override void Hook() => Console.WriteLine("Optional hook executed");
//    }

//    public static class TemplatePattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Template Pattern ===");
//            var template = new ConcreteTemplate();
//            template.Execute();
//        }
//    }
//}