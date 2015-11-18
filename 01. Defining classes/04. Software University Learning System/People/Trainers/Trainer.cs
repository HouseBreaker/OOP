using System;

namespace _04.Software_University_Learning_System.People.Trainers
{
	public abstract class Trainer : Person
	{
		protected Trainer(string firstName, string lastName, int age) :
			base(firstName, lastName, age)
		{
		}

		protected void CreateCourse(string name)
		{
			Console.WriteLine($"Course {name} has been created by {FirstName} {LastName}.");
		}
	}
}