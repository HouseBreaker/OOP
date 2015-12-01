using System;
using _02.Bank_of_Kurtovo_Konare.Customers;
using _02.Bank_of_Kurtovo_Konare.Interfaces;

namespace _02.Bank_of_Kurtovo_Konare.Accounts
{
	public abstract class Account : IAccount, IDepositable
	{
		private ICustomer customer;
		private decimal balance;
		private decimal monthlyInterestRate;

		protected Account(Customer customer, decimal balance, decimal monthlyInterestRate)
		{
			this.Customer = customer;
			this.Balance = balance;
			this.MonthlyInterestRate = monthlyInterestRate;
		}

		public ICustomer Customer
		{
			get { return customer; }
			set { customer = value; }
		}

		public decimal Balance
		{
			get { return balance; }
			set { balance = value; }
		}

		public decimal MonthlyInterestRate
		{
			get { return monthlyInterestRate; }
			set { monthlyInterestRate = value; }
		}

		public virtual decimal CalculateInterest(int periodInMonths)
		{
			// A = money * (1 + interest rate * months)

			return Balance*(1 + MonthlyInterestRate*periodInMonths);
		}

		public void Deposit(decimal amountOfMoney)
		{
			this.Balance += amountOfMoney;
		}
	}
}