using System.Collections.Generic;
using System.Linq;
using System.Text;
using _03.Company.Enums;
using _03.Company.Interfaces;

namespace _03.Company.People.Employees
{
	public class Developer : Employee, IDeveloper
	{
		public List<IProject> Projects { get; set; }

		public Developer(string firstName, string lastName, string id, decimal salary, Department department,
			List<IProject> projects)
			: base(firstName, lastName, id, salary, department)
		{
			this.Projects = projects;
		}

		public override string ToString()
		{
			var sb = new StringBuilder(base.ToString());

			sb.AppendLine();
			sb.Append(Tab + "Projects: ".PadRight(PrintPadding));
			sb.Append(string.Join(", ", Projects.Select(a => $"{a.Name} ({a.State})")));
			
			return sb.ToString();
		}
	}
}