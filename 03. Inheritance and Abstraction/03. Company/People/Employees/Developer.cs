using System.Collections.Generic;
using _03.Company.Commodities;
using _03.Company.Enums;

namespace _03.Company.People.Employees
{
	internal class Developer : RegularEmployee
	{
		public List<Project> Projects { get; set; }

		public Developer(string firstName, string lastName, string id, decimal salary, Department department,
			List<Project> projects)
			: base(firstName, lastName, id, salary, department)
		{
			this.Projects = projects;
		}
	}
}