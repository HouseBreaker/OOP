using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _03.Company.Enums;

namespace _03.Company.People.Employees
{
	public class Manager : Employee
	{
		public Manager(string firstName, string lastName, string id, decimal salary, Department department,
			List<Employee> employees) :
				base(firstName, lastName, id, salary, department)
		{
			this.Employees = employees;
		}

		public List<Employee> Employees { get; set; }

		public override string ToString()
		{
			var sb = new StringBuilder(base.ToString());
			sb.Append(tab + "Employees".PadRight(PrintPadding));

			sb.Append(Employees.Count + ": " + string.Join(", ", Employees.Select(a => $"{a.FirstName} {a.LastName}")));
			return sb.ToString();
		}
	}
}