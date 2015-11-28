using System.Collections.Generic;
using System.Linq;
using System.Text;
using _03.Company.Enums;
using _03.Company.Interfaces;

namespace _03.Company.People.Employees
{
	public class Manager : Employee, IManager
	{
		public List<IEmployee> Employees { get; set; }

		public Manager(string firstName, string lastName, string id, decimal salary, Department department,
			List<IEmployee> employees) :
				base(firstName, lastName, id, salary, department)
		{
			this.Employees = employees;
		}

		public override string ToString()
		{
			var sb = new StringBuilder(base.ToString());
			sb.Append(Tab + "Employees".PadRight(PrintPadding));

			sb.Append($"{Employees.Count}: " + string.Join(", ", Employees.Select(a => $"{a.FirstName} {a.LastName}")));
            return sb.ToString();
		}
	}
}