using System;

namespace _03.Inheritance_and_Abstraction
{
	public class Worker : Human
	{
		private double weekSalary;
		private int workHoursPerDay;

		public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay) 
			: base(firstName, lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.WeekSalary = weekSalary;
			this.WorkHoursPerDay = workHoursPerDay;
		}

		public double WeekSalary
		{
			get
			{
				return this.weekSalary;
			}
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
			get
			{
				return this.workHoursPerDay;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentNullException("workHoursPerDay", "Work hours per day cannot be negative.");
				}
				this.workHoursPerDay = value;
			}
		}

		public double MoneyPerHour()
		{
			return WeekSalary / 7 / workHoursPerDay;
		}

		public override string ToString()
		{
			return $"Name: {FirstName.PadRight(6)} {LastName.PadRight(7)} Weekly Salary: {WeekSalary}, Work hours per day: {WorkHoursPerDay.ToString().PadRight(2)} Wage: ${MoneyPerHour():F2}";
		}
	}
}
