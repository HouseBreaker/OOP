using _03.Company.Enums;

namespace _03.Company.People.Employees
{
	public class RegularEmployee : Employee
	{
		public RegularEmployee(string firstName, string lastName, string id, decimal salary, Department department)
			: base(firstName, lastName, id, salary, department)
		{
		}
	}
}