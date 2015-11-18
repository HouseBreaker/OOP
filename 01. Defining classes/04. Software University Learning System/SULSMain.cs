using System;
using System.Collections.Generic;
using System.Linq;
using _04.Software_University_Learning_System.People;
using _04.Software_University_Learning_System.People.Students;
using _04.Software_University_Learning_System.People.Trainers;

namespace _04.Software_University_Learning_System
{
	class SULSMain
	{
		static void Main(string[] args)
		{
			var people = new List<Person>()
			{
				new CurrentStudent("Gosho", "Ivanov", 25, 9234857, 5.5, "OOP"),
				new CurrentStudent("Katya", "Georgieva", 30, 9234859, 4.5, "Java Fundamentals"),
				new OnsiteStudent("Pesho", "Todorov", 18, 477377, 4, "Web Fundamentals", 30),
				new OnlineStudent("On", "Lainov", 22, 2382384, 5.34, "High Quality Code"),
				new GraduateStudent("Lain", "Onov", 26, 2385584, 3.10),
				new DropoutStudent("Svetlin", "Nakov", 35, 1, 2, "C# Basics"),
				new SeniorTrainer("Ivan", "Yonkov", 25),
				new JuniorTrainer("Gosho", "Peshov", 19),
			};
			var filteredPeople = people.OfType<CurrentStudent>().OrderByDescending(a => a.AverageGrade);

			Console.WriteLine(string.Join(Environment.NewLine, filteredPeople));
		}
	}
}
