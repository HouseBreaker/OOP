using System.Collections.Generic;
using System.Linq;
using System.Text;
using _03.Company.Enums;
using _03.Company.Interfaces;

namespace _03.Company.People.Employees
{
	public class SalesEmployee : RegularEmployee, ISalesEmployee
	{
		public List<ISale> Sales { get; set; }

		public SalesEmployee(string firstName, string lastName, string id, decimal salary, List<ISale> sales)
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