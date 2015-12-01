using _02.Bank_of_Kurtovo_Konare.Customers;
using _02.Bank_of_Kurtovo_Konare.Interfaces;

namespace _02.Bank_of_Kurtovo_Konare.Accounts
{
	public class DepositAccount : Account, IWithdrawable
	{
		public DepositAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
			: base(customer, balance, monthlyInterestRate)
		{
		}

		public void Withdraw(decimal money)
		{
			this.Balance -= money;
		}

		public override decimal CalculateInterest(int periodInMonths)
		{
			if (this.Balance > 0 && this.Balance < 1000)
			{
				return base.CalculateInterest(0);
			}

			return base.CalculateInterest(periodInMonths);
		}
	}
}