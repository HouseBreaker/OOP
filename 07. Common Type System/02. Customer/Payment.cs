using System;

namespace _02.Customer
{
	public class Payment
	{
		private string name;
		private decimal price;

		public Payment(string name, decimal price)
		{
			this.Name = name;
			this.Price = price;
		}

		public string Name
		{
			get { return name; }
			private set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("name", "Name cannot be empty.");
				}
				name = value;
			}
		}

		public decimal Price
		{
			get { return price; }
			private set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("price", "Price cannot be negative");
				}
				price = value;
			}
		}

		public override string ToString()
		{
			return $"{Name} ({Price:C})";
		}
	}
}