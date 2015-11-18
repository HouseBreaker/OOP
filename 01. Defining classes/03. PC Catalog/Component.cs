using System;

namespace _03.PC_Catalog
{
	internal class Component
	{
		private string name;
		private string details;
		private decimal price;

		public Component(string name, string details, decimal price)
		{
			this.name = name;
			this.details = details;
			this.price = price;
		}

		public Component(string name, decimal price)
			: this(name, null, price)
		{
		}

		public string Name
		{
			get { return name; }
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Component name cannot be null or empty.");
				}
				name = value;
			}
		}

		public string Details
		{
			get { return details; }
			set
			{
				if (value == string.Empty)
				{
					throw new ArgumentException("Component details cannot be empty.");
				}
				details = value;
			}
		}

		public decimal Price
		{
			get { return price; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException(nameof(value), "Component price cannot be negative.");
				}
				price = value;
			}
		}

		public override string ToString()
		{
			if (Details == null)
			{
				return $"Name: {Name}, Price: {Price:C}";
			}
			return $"Name: {Name}, Details: {Details}, Price: {Price:C}";
		}
	}
}