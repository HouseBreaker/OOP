using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using _03.Inheritance_and_Abstraction.People;

namespace _03.Inheritance_and_Abstraction
{
	internal class PeopleMain
	{
		private static void Main()
		{
			List<Student> studentList = new List<Student>()
			{
				new Student("Gosho", "Ivanov", "nrwF6Jd"),
				new Student("Ashton", "Gyles", "6YOuQys"),
				new Student("Austen", "Barrett", "suQ7TTq"),
				new Student("Oswald", "Brennan", "wVV8fc0"),
				new Student("Oli", "Knox", "QdKYpdf"),
			};

			Console.WriteLine("Students");
			Console.WriteLine(string.Join(Environment.NewLine, studentList));

			studentList = studentList.OrderBy(student => student.FacultyNumber).ToList();

			Console.WriteLine(Environment.NewLine + "Students sorted by Faculty Number");
			Console.WriteLine(string.Join(Environment.NewLine, studentList));

			var workerList = new List<Worker>()
			{
				new Worker("Dillon", "Brennan", 500, 8),
				new Worker("Frank", "Kyler", 300, 6),
				new Worker("Andrew", "Dalton", 450, 6),
				new Worker("Shayne", "Rodge", 500, 8),
				new Worker("Terry", "Phillip", 700, 12),
			};

			Console.WriteLine(Environment.NewLine + "Workers");
			Console.WriteLine(string.Join(Environment.NewLine, workerList));

			workerList = workerList.OrderBy(worker => worker.MoneyPerHour()).ToList();


			Console.WriteLine(Environment.NewLine + "Workers sorted by wage");
			Console.WriteLine(string.Join(Environment.NewLine, workerList));

			var combinedList = new List<Human>();
			combinedList.AddRange(studentList);
			combinedList.AddRange(workerList);

			combinedList = combinedList.OrderBy(s => s.FirstName).ToList();

			Console.WriteLine();
			Console.WriteLine("Combined list ordered by First Name");
			combinedList.ForEach(human => Console.WriteLine($"{human.FirstName} {human.LastName}"));

			combinedList = combinedList.OrderBy(s => s.LastName).ToList();

			Console.WriteLine();
			Console.WriteLine("Combined list ordered by Last Name");
			combinedList.ForEach(human => Console.WriteLine($"{human.FirstName} {human.LastName}"));
		}
	}
}