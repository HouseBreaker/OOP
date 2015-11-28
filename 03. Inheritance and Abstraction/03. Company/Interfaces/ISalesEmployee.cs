using System.Collections.Generic;

namespace _03.Company.Interfaces
{
	interface ISalesEmployee : IRegularEmployee
	{
		List<ISale> Sales { get; set; }
	}
}
