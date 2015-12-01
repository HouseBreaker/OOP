using System;
using _02.Bank_of_Kurtovo_Konare.Customers;

namespace _02.Bank_of_Kurtovo_Konare.Accounts
{
	public class MortgageAccount : Account
	{
		public MortgageAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
			: base(customer, balance, monthlyInterestRate)
		{
		}

		public override decimal CalculateInterest(int periodInMonths)
		{
			int monthsWithFullInterest;
			var interest = 0m;

			switch (this.Customer.CustomerType)
			{
				case CustomerType.Company:
					const int monthsWithHalfInterest = 12;
					interest += this.Balance*(1 + (this.MonthlyInterestRate/2*periodInMonths));
					monthsWithFullInterest = Math.Max(0, periodInMonths - monthsWithHalfInterest);
					interest += base.CalculateInterest(monthsWithFullInterest);
					break;

				case CustomerType.Individual:
					const int monthsWithNoInterest = 6;
					monthsWithFullInterest = Math.Max(0, periodInMonths - monthsWithNoInterest);
					interest = base.CalculateInterest(monthsWithFullInterest);
					break;
			}

			return interest;
		}
	}
}