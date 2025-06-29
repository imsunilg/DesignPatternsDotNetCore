using System;

namespace DesignPatternsDotNetCore
{
    // Command interface
    public interface ICommand
    {
        void Execute();
    }

    // Receiver class: performs the actual action
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Receiver Action executed");
        }
    }

    // ConcreteCommand: binds a receiver to an action
    public class ConcreteCommand : ICommand
    {
        private readonly Receiver _receiver;

        public ConcreteCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Action();
        }
    }

    // Invoker: holds and executes a command
    public class Invoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }

    // Entry class for running the Command pattern example
    public static class CommandPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Command Pattern ===");

            // Receiver object
            Receiver receiver = new Receiver();

            // Create command and set its receiver
            ConcreteCommand command = new ConcreteCommand(receiver);

            // Invoker sets and calls the command
            Invoker invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}

//using System;
//using System.Collections.Generic;

//namespace DesignPatternsDotNetCore
//{
//    public interface ICommand
//    {
//        void Execute();
//    }

//    public class Receiver
//    {
//        public void Action() => Console.WriteLine("Receiver Action executed");
//    }

//    public class ConcreteCommand : ICommand
//    {
//        private readonly Receiver _receiver;
//        public ConcreteCommand(Receiver receiver) => _receiver = receiver;
//        public void Execute() => _receiver.Action();
//    }

//    public class Invoker
//    {
//        private ICommand _command;
//        public void SetCommand(ICommand command) => _command = command;
//        public void ExecuteCommand() => _command.Execute();
//    }

//    public static class CommandPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Command Pattern ===");
//            var receiver = new Receiver();
//            var command = new ConcreteCommand(receiver);
//            var invoker = new Invoker();
//            invoker.SetCommand(command);
//            invoker.ExecuteCommand();
//        }
//    }
//}