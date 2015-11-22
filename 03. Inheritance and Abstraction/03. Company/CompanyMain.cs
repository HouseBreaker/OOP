using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using _03.Company.Commodities;
using _03.Company.Enums;
using _03.Company.People.Employees;

namespace _03.Company
{
	internal class CompanyMain
	{
		private static void Main()
		{ 
			// someone please explain to me why i'm supposed to use interfaces when my setters ensure data will be valid

			Console.OutputEncoding = Encoding.UTF8;
			Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

			var cook = new RegularEmployee("Uti", "Bachvarov", "musaka123", 400, Department.Production);

			var marketingRep = new SalesEmployee("Ivo", "Peshov", "333drivesales", 500, new List<Sale>
			{
				new Sale("Super toothpaste Colgate Max #000", DateTime.Today, 500)
			});

			var salesman = new SalesEmployee("Ivan", "Ivanov", "234235", 5000, new List<Sale>()
			{
				new Sale("Dell PC", DateTime.Now, 340),
				new Sale("cigarettes", DateTime.Now.AddDays(2), 4.5M),
			});

			var developer = new Developer("gosho", "deva", "0xffff", 3000, Department.Production, new List<Project>()
			{
				new Project("Z# Programming language", DateTime.Now, "the language to end them all", State.Open),
				new Project("New Objective C", DateTime.Today, "OOP on a new level", State.Open),
			});

			var manager = new Manager("Gosho", "Peshov", "8227337ss", 250, Department.Accounting, new List<Employee>()
			{
				cook,
				marketingRep,
				salesman,
				developer
			});

			Console.WriteLine("Company:");
			developer.Projects[1].CloseProject();

			Console.WriteLine($"Employees of {manager.Name}: ");
			Console.WriteLine(string.Join("\n\n", manager.Employees));
		}
	}
}