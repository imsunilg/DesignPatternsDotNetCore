using System;
using System.Collections.Generic;

namespace DesignPattern.referenceDesignCode
{
    // Expression interface
    public interface IExpression
    {
        int Interpret(Dictionary<string, int> context);
    }

    // Terminal expression for numbers
    public class Number : IExpression
    {
        private int _number;

        public Number(int number)
        {
            _number = number;
        }

        public int Interpret(Dictionary<string, int> context)
        {
            return _number;
        }
    }

    // Terminal expression for variables
    public class Variable : IExpression
    {
        private string _name;

        public Variable(string name)
        {
            _name = name;
        }

        public int Interpret(Dictionary<string, int> context)
        {
            return context[_name];
        }
    }

    // Non-terminal expression for addition
    public class Add : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        public Add(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret(Dictionary<string, int> context)
        {
            return _left.Interpret(context) + _right.Interpret(context);
        }
    }

    // Runner class
    public static class InterpreterPattern
    {
        public static void Execute()
        {
            Console.WriteLine("=== Interpreter Pattern ===");

            Dictionary<string, int> context = new Dictionary<string, int>();
            context["x"] = 5;
            context["y"] = 10;

            IExpression expression = new Add(new Variable("x"), new Variable("y"));

            int result = expression.Interpret(context);
            Console.WriteLine("Result: " + result);
        }
    }
}

//using System;
//using System.Collections.Generic;

//namespace DesignPatternsDotNetCore
//{
//    public interface IExpression
//    {
//        int Interpret(Dictionary<string, int> context);
//    }

//    public class Number : IExpression
//    {
//        private readonly int _number;
//        public Number(int number) => _number = number;
//        public int Interpret(Dictionary<string, int> context) => _number;
//    }

//    public class Variable : IExpression
//    {
//        private readonly string _name;
//        public Variable(string name) => _name = name;
//        public int Interpret(Dictionary<string, int> context) => context[_name];
//    }

//    public class Add : IExpression
//    {
//        private readonly IExpression _left, _right;
//        public Add(IExpression left, IExpression right) => (_left, _right) = (left, right);
//        public int Interpret(Dictionary<string, int> context) => _left.Interpret(context) + _right.Interpret(context);
//    }

//    public static class InterpreterPattern
//    {
//        public static void Execute()
//        {
//            Console.WriteLine("=== Interpreter Pattern ===");
//            var context = new Dictionary<string, int> { ["x"] = 5, ["y"] = 10 };
//            IExpression expression = new Add(new Variable("x"), new Variable("y"));
//            Console.WriteLine("Result: " + expression.Interpret(context));
//        }
//    }
//}