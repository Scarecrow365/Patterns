namespace Facade.Ex2
{
    public class Mortgage
    {
        private readonly Bank _bank = new Bank();
        private readonly Loan _loan = new Loan();
        private readonly Credit _credit = new Credit();

        public bool IsEligible(Customer customer, int amount)
        {
            var eligible = false;

            if (_bank.HasSufficientSavings(customer, amount))
            {
                eligible = true;
            }
            else if (_loan.HasNoBadLoans(customer))
            {
                eligible = true;
            }
            else if (_credit.HasGoodCredit(customer))
            {
                eligible = true;
            }

            return eligible;
        }

    }
}