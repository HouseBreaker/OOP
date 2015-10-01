using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inheritance_and_Abstraction
{
	class PeopleMain
	{
		static void Main()
		{
			List<Student> studentList = new List<Student>()
			{
				new Student("Gosho", "Ivanov", "YpEBVq4V"),
				new Student("Ashton", "Gyles", "kRDbt1wf"),
				new Student("Austen", "Barrett", "yB6XO63g"),
				new Student("Oswald", "Brennan", "q1eqJsxV"),
				new Student("Oli", "Knox", "TPEZUnZM"),
			};
			Console.WriteLine("Students");
			Console.WriteLine(string.Join(Environment.NewLine, studentList));

			studentList = studentList.OrderBy(student => student.FacultyNumber).ToList();

			Console.WriteLine(Environment.NewLine + "Sorted by Faculty Number");
			Console.WriteLine(string.Join(Environment.NewLine, studentList));

			List<Worker> workerList = new List<Worker>()
			{
				new Worker("Dillon", "Brennan", 500, 8),
				new Worker("Frank", "Kyler", 300, 6),
				new Worker("Andrew", "Dalton", 450, 6),
				new Worker("Shayne", "Rodge", 500, 8),
				new Worker("Terry", "Phillip", 700, 12),
			};

			Console.WriteLine();
			Console.WriteLine(string.Join(Environment.NewLine, workerList));

			workerList = workerList.OrderBy(worker => worker.MoneyPerHour()).ToList();


			Console.WriteLine(Environment.NewLine + "Sorted by wage");
			Console.WriteLine(string.Join(Environment.NewLine, workerList));
			
			List<Human> combinedList = new List<Human>();
			combinedList.AddRange(studentList);
			combinedList.AddRange(workerList);

			combinedList = combinedList.OrderBy(s => s.FirstName).ToList();

			Console.WriteLine();
			Console.WriteLine("Combined list ordered by First Name");
			Console.WriteLine(string.Join(Environment.NewLine, combinedList));

			combinedList = combinedList.OrderBy(s => s.LastName).ToList();

			Console.WriteLine();
			Console.WriteLine("Combined list ordered by Last Name");
			Console.WriteLine(string.Join(Environment.NewLine, combinedList));

		}
	}
}