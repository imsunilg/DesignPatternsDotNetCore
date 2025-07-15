using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.selfCode
{



    // Implementor
    public interface IPolicyProduct
    {
        string Generate();
    }

    // Abstraction
    public abstract class PolicyChannel
    {
        protected IPolicyProduct _product;

        protected PolicyChannel(IPolicyProduct product)
        {
            _product = product;
        }

        public abstract void Generate();
    }

    // Refined Abstractions
    public class AgentChannel : PolicyChannel
    {
        public AgentChannel(IPolicyProduct product) : base(product) { }

        public override void Generate()
        {
            Console.WriteLine("Agent Channel: " + _product.Generate());
        }
    }

    public class WebChannel : PolicyChannel
    {
        public WebChannel(IPolicyProduct product) : base(product) { }

        public override void Generate()
        {
            Console.WriteLine("Web Channel: " + _product.Generate());
        }
    }

    public class BranchChannel : PolicyChannel
    {
        public BranchChannel(IPolicyProduct product) : base(product) { }

        public override void Generate()
        {
            Console.WriteLine("Branch Channel: " + _product.Generate());
        }
    }

    // Concrete Implementors (Products)
    public class MotorPolicy : IPolicyProduct
    {
        public string Generate()
        {
            return "Motor Policy Generated";
        }
    }

    public class HealthPolicy : IPolicyProduct
    {
        public string Generate()
        {
            return "Health Policy Generated";
        }
    }

    public class LifePolicy : IPolicyProduct
    {
        public string Generate()
        {
            return "Life Policy Generated";
        }
    }

    // Client
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        PolicyChannel policy1 = new AgentChannel(new MotorPolicy());
    //        policy1.Generate();  // Agent Channel: Motor Policy Generated

    //        PolicyChannel policy2 = new WebChannel(new HealthPolicy());
    //        policy2.Generate();  // Web Channel: Health Policy Generated

    //        PolicyChannel policy3 = new BranchChannel(new LifePolicy());
    //        policy3.Generate();  // Branch Channel: Life Policy Generated

    //        PolicyChannel policy4 = new WebChannel(new LifePolicy());
    //        policy4.Generate();  // Web Channel: Life Policy Generated

    //        Console.ReadLine();
    //    }
    //}
    /// <summary>
    /// Bridge Pattern Example with Car and Bike as Vehicles with different Engines
    /// </summary>
    public interface IEngine {

        string Refill();
    }
    public abstract class IVehicle
    {
        protected IEngine _engine;
        protected IVehicle(IEngine engine)
        {
            this._engine = engine;
        }
        public abstract void Refill();
    }

    public class Car : IVehicle
    {
        public Car(IEngine engine) : base(engine)
        {
        }

        public override void Refill()
        {
            Console.WriteLine("Car: "+ _engine.Refill());
        }
    }
    public class Bike: IVehicle
    {
        public Bike(IEngine engine) : base(engine)
        {
        }

        public override void Refill()
        {
            Console.WriteLine("Bike: "+ _engine.Refill());
        }
    }

    class ElectricEngine : IEngine { 
        public string Refill()
        {
            return "Electric Engine Charged to 100%";
        }
    }
   class petrolEngine : IEngine
    {
        public string Refill()
        {
            return "Petrol Engine Refueled to 5 Liter";
        }
    }

 
}
