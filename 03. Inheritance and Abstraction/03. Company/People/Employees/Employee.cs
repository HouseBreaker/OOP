using System;
using System.Text;
using _03.Company.Enums;

namespace _03.Company.People.Employees
{
	public abstract class Employee : Person
	{
		private decimal salary;
		public Department Department { get; set; }

		protected Employee(string firstName, string lastName, string id, decimal salary, Department department) :
			base(firstName, lastName, id)
		{
			this.Salary = salary;
			this.Department = department;
		}

		public decimal Salary
		{
			get { return salary; }
			set { salary = ValidateNum(value, "Salary"); }
		}

		public override string ToString()
		{
			var sb = new StringBuilder(base.ToString() + Environment.NewLine);
			sb.AppendLine(Tab + "Salary".PadRight(PrintPadding) + Salary.ToString("C"));
			sb.Append(Tab + "Department".PadRight(PrintPadding) + Department);

			return sb.ToString();
		}
	}
}