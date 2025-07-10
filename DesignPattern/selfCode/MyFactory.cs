using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.selfCode
{ 
    //Product
    public interface IPizza
    {
        string Eat();
    }
    //Concrete Product VegPizza
    class VegPizza : IPizza
    {
        public string Eat()
        {
            return "Veg Pizza";
        }
    }
    //Concrete Product non-VegPizza
    class nonVegPizza : IPizza
    {
        public string Eat()
        {
            return "Non Veg Pizza";
        }
    }
    // Factory Class
    interface IPizzaChef
    {
        IPizza PreparePizza();
    }

    class VegPizzaChef : IPizzaChef
    {
        public IPizza PreparePizza()
        {
            return new VegPizza();
        }
    }

    class NonVegPizzaChef : IPizzaChef
    {
        public IPizza PreparePizza()
        {
            return new nonVegPizza();
        }
    }
     class Waiter //client
     {
        public IPizza GetPizza(string type) {
            IPizzaChef vegPizzaChef;
            switch (type.ToLower()) { 
                case "veg":
                    vegPizzaChef = new VegPizzaChef();
                    break; 
            default:
                    vegPizzaChef = new NonVegPizzaChef();
                    break;
            }
            return vegPizzaChef.PreparePizza();
        }
    }


    // Example usage IInsurancePolicy

    public interface IInsurancePolicy
    {
        string GetPolicyDetails();
    }

    // Fixed the class declaration to implement the correct interface name without typos.
    public class MotorInsurance : IInsurancePolicy
    {
        public string GetPolicyDetails()
        {
            return "Motor Insurance Policy Details";
        }
    }
    public class HealthInsurance : IInsurancePolicy
    {
        public string GetPolicyDetails()
        {
            return "Health Insurance Policy Details";
        }
    }
    public class LiabilityInsurance : IInsurancePolicy
    {
        public string GetPolicyDetails()
        {
            return "Liability Insurance Policy Details";
        }
    }

    public static class IInsurancePolicyFactory
    {
        public static IInsurancePolicy CreatePolicy(string policyType)
        {

            switch (policyType.ToLower())
            {
                case "motor":
                    return new MotorInsurance();
                case "health":
                    return new HealthInsurance();
                case "liability":
                    return new HealthInsurance();
                default:
                    throw new ArgumentException("Invalid policy type");
            }
        }

    }
}
