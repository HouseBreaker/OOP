using System;
using _03.Company.Enums;

namespace _03.Company.Commodities
{
	public class Project
	{
		public string Name { get; set; }
		public DateTime StartDate { get; set; }
		public string Details { get; set; }
		public State ProjectState { get; set; }

		public Project(string name, DateTime startDate, string details, State projectState)
		{
			this.Name = name;
			this.StartDate = startDate;
			this.Details = details;
			this.ProjectState = projectState;
		}

		public void OpenProject()
		{
			this.ProjectState = State.Open;
			Console.WriteLine($"Project {Name} Opened.");
		}

		public void CloseProject()
		{
			this.ProjectState = State.Closed;
			Console.WriteLine($"Project {Name} Closed.");
		}

		public override string ToString()
		{
			return $"Name: {Name}, Start date: {StartDate}, Details: {Details}, State: {ProjectState}";
		}
	}
}