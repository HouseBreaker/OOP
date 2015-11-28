using System;
using _03.Company.Enums;
using _03.Company.Interfaces;

namespace _03.Company.Commodities
{
	public class Project : IProject
	{
		public string Name { get; set; }

		public DateTime StartDate { get; set; }

		public string Details { get; set; }

		public State State { get; set; }

		public Project(string name, DateTime startDate, string details, State projectState)
		{
			this.Name = name;
			this.StartDate = startDate;
			this.Details = details;
			this.State = projectState;
		}

		public void OpenProject()
		{
			this.State = State.Open;
			Console.WriteLine($"Project {Name} Opened.");
		}

		public void CloseProject()
		{
			this.State = State.Closed;
			Console.WriteLine($"Project {Name} Closed.");
		}

		public override string ToString()
		{
			return $"Name: {Name}, Start date: {StartDate}, Details: {Details}, State: {State}";
		}
	}
}