using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.InsuranceCompany.Structural
{

    public abstract class InsuranceComponent
    {
        public abstract void ShowDetails();
    }

    public class InsuranceProduct : InsuranceComponent
    {
        private string _productName;

        public InsuranceProduct(string name)
        {
            _productName = name;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Product: " + _productName);
        }
    }

    public class ProductPackage : InsuranceComponent
    {
        private List<InsuranceComponent> _components = new List<InsuranceComponent>();
        private string _packageName;

        public ProductPackage(string name)
        {
            _packageName = name;
        }

        public void AddComponent(InsuranceComponent component)
        {
            _components.Add(component);
        }

        public void RemoveComponent(InsuranceComponent component)
        {
            _components.Remove(component);
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Package: " + _packageName);
            foreach (var component in _components)
            {
                component.ShowDetails();
            }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        InsuranceComponent health = new InsuranceProduct("Health Insurance");
    //        InsuranceComponent life = new InsuranceProduct("Life Insurance");
    //        InsuranceComponent vehicle = new InsuranceProduct("Vehicle Insurance");

    //        ProductPackage familyPack = new ProductPackage("Family Combo Pack");
    //        familyPack.AddComponent(health);
    //        familyPack.AddComponent(life);

    //        ProductPackage ultimatePack = new ProductPackage("Ultimate Security Pack");
    //        ultimatePack.AddComponent(familyPack);
    //        ultimatePack.AddComponent(vehicle);

    //        ultimatePack.ShowDetails();
    //    }
    //}
}