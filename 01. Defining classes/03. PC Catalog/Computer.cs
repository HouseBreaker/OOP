using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.PC_Catalog
{
	internal class Computer
	{
		private string name;
		private decimal price;

		public Computer(string name, List<Component> components)
		{
			this.Name = name;
			this.Components = components;
			this.price = Components.Sum(a => a.Price);
		}

		public string Name
		{
			get { return name; }
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Computer name cannot be null or empty.");
				}
				name = value;
			}
		}

		public List<Component> Components { get; set; }

		public decimal Price
		{
			get { return price; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException(nameof(value), "Computer price cannot be negative.");
				}
				price = value;
			}
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			int tabLength = 3;
			int namePad = Components.Max(c => c.Name.Length) + 2;

			int detailsPad = Components.Where(c => c.Details != null).Max(c => c.Details.Length) + 2;
			

			sb.AppendLine($"PC name: {Name}");
			sb.AppendLine("Components:");

			foreach (var c in Components)
			{
				sb.Append("".PadRight(tabLength));
				sb.Append("Name: " + c.Name.PadRight(namePad));

				if (c.Details != null)
				{
					sb.Append("Details: " + c.Details.PadRight(detailsPad));
				}

				sb.AppendLine("Price: " + $"{c.Price:C}");
			}
			sb.Append($"Total price: {Price:C}");

			return sb.ToString();
		}
	}
}