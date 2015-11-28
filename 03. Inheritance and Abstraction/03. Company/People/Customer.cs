using _03.Company.Interfaces;

namespace _03.Company.People
{
	public class Customer : Person, ICustomer
	{
		public decimal NetPurchaseAmount { get; set; }

		public Customer(string firstName, string lastName, string id, decimal netPurchaseAmount) :
			base(firstName, lastName, id)
		{
			this.NetPurchaseAmount = netPurchaseAmount;
		}

		public override string ToString()
		{
			return base.ToString() + '\n' +
				Tab + $"Net balance {NetPurchaseAmount:C}";
		}
	}
}