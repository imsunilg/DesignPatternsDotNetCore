using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.InsuranceCompany.Structural
{
    public class PolicyVerification
    {
        public bool VerifyPolicy(string policyNumber)
        {
            Console.WriteLine("Verifying policy: " + policyNumber);
            return true;
        }
    }

    public class ClaimValidation
    {
        public bool ValidateClaimAmount(decimal amount)
        {
            Console.WriteLine("Validating claim amount: Rs." + amount);
            return amount <= 100000; // max cap for demo
        }
    }

    public class PayoutProcessor
    {
        public void ProcessPayout(string policyNumber, decimal amount)
        {
            Console.WriteLine("Processing payout of Rs." + amount + " for policy: " + policyNumber);
        }
    }

    public class InsuranceClaimFacade
    {
        private PolicyVerification _policyVerifier;
        private ClaimValidation _claimValidator;
        private PayoutProcessor _payoutProcessor;

        public InsuranceClaimFacade()
        {
            _policyVerifier = new PolicyVerification();
            _claimValidator = new ClaimValidation();
            _payoutProcessor = new PayoutProcessor();
        }

        public void HandleClaim(string policyNumber, decimal claimAmount)
        {
            if (_policyVerifier.VerifyPolicy(policyNumber) &&
                _claimValidator.ValidateClaimAmount(claimAmount))
            {
                _payoutProcessor.ProcessPayout(policyNumber, claimAmount);
            }
            else
            {
                Console.WriteLine("Claim denied.");
            }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        InsuranceClaimFacade claimFacade = new InsuranceClaimFacade();
    //        claimFacade.HandleClaim("POL123456", 85000);
    //    }
    //}
}