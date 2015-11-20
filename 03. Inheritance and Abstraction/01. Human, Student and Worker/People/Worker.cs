using System;

namespace _03.Inheritance_and_Abstraction.People
{
	public class Worker : Human
	{
		private decimal weekSalary;
		private int workHoursPerDay;

		public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
			: base(firstName, lastName)
		{
			this.WeekSalary = weekSalary;
			this.WorkHoursPerDay = workHoursPerDay;
		}

		public decimal WeekSalary
		{
			get { return this.weekSalary; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentNullException("weekSalary", "Week salary cannot be negative.");
				}
				this.weekSalary = value;
			}
		}

		public int WorkHoursPerDay
		{
			get { return this.workHoursPerDay; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentNullException("workHoursPerDay", "Work hours per day cannot be negative.");
				}
				this.workHoursPerDay = value;
			}
		}

		public decimal MoneyPerHour()
		{
			return WeekSalary/7/workHoursPerDay;
		}

		public override string ToString()
		{
			return base.ToString() +
			       $" Weekly Salary: {WeekSalary:C}, " +
			       $"Work hours per day: {WorkHoursPerDay.ToString().PadRight(2)} " +
			       $"Wage: ${MoneyPerHour():F2}/hr";
		}
	}
}