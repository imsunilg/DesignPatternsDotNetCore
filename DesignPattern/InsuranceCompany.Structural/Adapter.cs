using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.InsuranceCompany.Structural
{
    public interface IPaymentProcessor
    {
        void MakePayment(string policyNumber, decimal amount);
    }

    public class ThirdPartyBankAPI
    {
        public void InitiateBankTransfer(string accountRef, double value)
        {
            Console.WriteLine("Third-party bank transfer initiated for Rs." + value + " to: " + accountRef);
        }
    }

    public class BankAdapter : IPaymentProcessor
    {
        private ThirdPartyBankAPI _bankAPI;

        public BankAdapter()
        {
            _bankAPI = new ThirdPartyBankAPI();
        }

        public void MakePayment(string policyNumber, decimal amount)
        {
            _bankAPI.InitiateBankTransfer(policyNumber, (double)amount);
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IPaymentProcessor paymentProcessor = new BankAdapter();
    //        paymentProcessor.MakePayment("POL456789", 10000);
    //    }
    //}
}