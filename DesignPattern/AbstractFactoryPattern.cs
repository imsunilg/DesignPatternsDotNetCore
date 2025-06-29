using System;

namespace DesignPatternsDotNetCore
{
    // Interface for Button component
    public interface IButton
    {
        void Paint();
    }

    // Interface for Checkbox component
    public interface ICheckbox
    {
        void Check();
    }

    // Windows-style Button implementation
    public class WinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("WinButton");
        }
    }

    // Mac-style Button implementation
    public class MacButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("MacButton");
        }
    }

    // Windows-style Checkbox implementation
    public class WinCheckbox : ICheckbox
    {
        public void Check()
        {
            Console.WriteLine("WinCheckbox");
        }
    }

    // Mac-style Checkbox implementation
    public class MacCheckbox : ICheckbox
    {
        public void Check()
        {
            Console.WriteLine("MacCheckbox");
        }
    }

    // Abstract factory interface
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

    // Concrete factory to create Windows-style UI components
    public class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }

    // Concrete factory to create Mac-style UI components
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }

    // Client code that demonstrates the Abstract Factory Pattern
    public static class AbstractFactoryPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Abstract Factory Pattern ===");

            // Use Windows factory to create UI components
            IGUIFactory factory = new WinFactory();

            // Create components using the selected factory
            IButton button = factory.CreateButton();
            ICheckbox checkbox = factory.CreateCheckbox();

            // Operate on the created components
            button.Paint();    // Output: WinButton
            checkbox.Check();  // Output: WinCheckbox
        }
    }
}



//using System;

//namespace DesignPatternsDotNetCore
//{
//    public interface IButton { void Paint(); }
//    public interface ICheckbox { void Check(); }

//    public class WinButton : IButton { public void Paint() => Console.WriteLine("WinButton"); }
//    public class MacButton : IButton { public void Paint() => Console.WriteLine("MacButton"); }

//    public class WinCheckbox : ICheckbox { public void Check() => Console.WriteLine("WinCheckbox"); }
//    public class MacCheckbox : ICheckbox { public void Check() => Console.WriteLine("MacCheckbox"); }

//    public interface IGUIFactory
//    {
//        IButton CreateButton();
//        ICheckbox CreateCheckbox();
//    }

//    public class WinFactory : IGUIFactory
//    {
//        public IButton CreateButton() => new WinButton();
//        public ICheckbox CreateCheckbox() => new WinCheckbox();
//    }

//    public class MacFactory : IGUIFactory
//    {
//        public IButton CreateButton() => new MacButton();
//        public ICheckbox CreateCheckbox() => new MacCheckbox();
//    }

//    public static class AbstractFactoryPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Abstract Factory Pattern ===");
//            IGUIFactory factory = new WinFactory();
//            var button = factory.CreateButton();
//            var checkbox = factory.CreateCheckbox();
//            button.Paint();
//            checkbox.Check();
//        }
//    }
//}