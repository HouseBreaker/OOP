using System;
using _03.Company.Enums;

namespace _03.Company.Interfaces
{
	public interface IProject
	{
		string Name { get; set; }

		DateTime StartDate { get; set; }

		string Details { get; set; }

		State State { get; set; }

		void CloseProject();
	}
}
