using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _03.Company.Commodities;
using _03.Company.Enums;

namespace _03.Company.People.Employees
{
	public class SalesEmployee : RegularEmployee
	{
		public List<Sale> Sales { get; set; }

		public SalesEmployee(string firstName, string lastName, string id, decimal salary, List<Sale> sales)
			: base(firstName, lastName, id, salary, Department.Sales)
		{
			this.Sales = sales;
		}

		public override string ToString()
		{
			var sb = new StringBuilder(base.ToString());

			sb.AppendLine();
			sb.Append(Tab + "Sales".PadRight(PrintPadding));
			sb.Append($"{Sales.Count}: ");
			sb.Append(string.Join(", ", Sales.Select(a => $"{a.Name} ({a.Price:C})")));

			return sb.ToString();
		}
	}
}