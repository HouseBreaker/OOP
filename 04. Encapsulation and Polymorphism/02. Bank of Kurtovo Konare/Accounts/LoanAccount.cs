using System;
using _02.Bank_of_Kurtovo_Konare.Customers;

namespace _02.Bank_of_Kurtovo_Konare.Accounts
{
	public class LoanAccount : Account
	{
		public LoanAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
			: base(customer, balance, monthlyInterestRate)
		{
		}

		public override decimal CalculateInterest(int periodInMonths)
		{
			var monthsWithoutInterest = this.Customer.CustomerType == CustomerType.Company ? 2 : 3;
			var monthsWithInterest = Math.Max(0, periodInMonths - monthsWithoutInterest);

			return base.CalculateInterest(monthsWithInterest);
		}
	}
}