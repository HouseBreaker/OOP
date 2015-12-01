using System;
using _02.Bank_of_Kurtovo_Konare.Interfaces;

namespace _02.Bank_of_Kurtovo_Konare.Customers
{
	public class Customer : ICustomer
	{
		private string name;
		private CustomerType customerType;

		public Customer(string name, CustomerType customerType)
		{
			this.Name = name;
			this.CustomerType = customerType;
		}

		public string Name
		{
			get { return name; }
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("Name", "Name cannot be null, empty or whitespace.");
				}
				name = value;
			}
		}

		public CustomerType CustomerType
		{
			get { return customerType; }
			set { customerType = value; }
		}
	}
}