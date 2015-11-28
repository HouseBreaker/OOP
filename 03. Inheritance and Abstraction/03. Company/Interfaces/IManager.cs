using System.Collections.Generic;

namespace _03.Company.Interfaces
{
	public interface IManager : IEmployee
	{
		List<IEmployee> Employees { get; set; }
	}
}