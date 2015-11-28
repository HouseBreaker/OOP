using System.Collections.Generic;

namespace _03.Company.Interfaces
{
	public interface IDeveloper : IRegularEmployee
	{
		List<IProject> Projects { get; set; }
	}
}