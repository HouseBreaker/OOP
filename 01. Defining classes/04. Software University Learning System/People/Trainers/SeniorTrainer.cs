using System;

namespace _04.Software_University_Learning_System.People.Trainers
{
	public class SeniorTrainer : Trainer
	{
		public SeniorTrainer(string firstName, string lastName, int age) :
			base(firstName, lastName, age)
		{
		}

		public void DeleteCourse(string name)
		{
			Console.WriteLine($"Course {name} deleted by {FirstName} {LastName}.");
		}
	}
}