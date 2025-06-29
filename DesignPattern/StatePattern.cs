using System;

namespace DesignPatternsDotNetCore
{
    // State Interface
    public interface IState
    {
        void Handle(ContextState context);
    }

    // Context
    public class ContextState
    {
        private IState _state;

        public ContextState(IState state)
        {
            _state = state;
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }

    // Concrete State A
    public class StateA : IState
    {
        public void Handle(ContextState context)
        {
            Console.WriteLine("Handling State A");
            context.SetState(new StateB());
        }
    }

    // Concrete State B
    public class StateB : IState
    {
        public void Handle(ContextState context)
        {
            Console.WriteLine("Handling State B");
            context.SetState(new StateA());
        }
    }

    // Pattern Executor
    public static class StatePattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== State Pattern ===");

            ContextState context = new ContextState(new StateA());
            context.Request(); // State A
            context.Request(); // State B
        }
    }
}

//using System;

//namespace DesignPatternsDotNetCore
//{
//    public interface IState
//    {
//        void Handle(ContextState context);
//    }

//    public class ContextState
//    {
//        private IState _state;
//        public ContextState(IState state) => _state = state;
//        public void SetState(IState state) => _state = state;
//        public void Request() => _state.Handle(this);
//    }

//    public class StateA : IState
//    {
//        public void Handle(ContextState context)
//        {
//            Console.WriteLine("Handling State A");
//            context.SetState(new StateB());
//        }
//    }

//    public class StateB : IState
//    {
//        public void Handle(ContextState context)
//        {
//            Console.WriteLine("Handling State B");
//            context.SetState(new StateA());
//        }
//    }

//    public static class StatePattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== State Pattern ===");
//            var context = new ContextState(new StateA());
//            context.Request();
//            context.Request();
//        }
//    }
//}