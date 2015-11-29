using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

using _03.Company.Commodities;
using _03.Company.Enums;
using _03.Company.Interfaces;
using _03.Company.People;
using _03.Company.People.Employees;

namespace _03.Company
{
	public static class CompanyMain
	{
		private static void Main()
		{
			Console.OutputEncoding = Encoding.UTF8;
			Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

			var cook = new RegularEmployee("Uti", "Bachvarov", "musaka123", 400m, Department.Production);

			var marketingRep = new SalesEmployee("Ivo", "Peshov", "333drivesales", 500m, new List<ISale>
			{
				new Sale("Super toothpaste Colgate Max #FFF", DateTime.Today, 500m)
			});

			var salesman = new SalesEmployee("Ivan", "Ivanov", "234235", 5000m, new List<ISale>()
			{
				new Sale("Dell PC", DateTime.Now, 340m),
				new Sale("cigarettes", DateTime.Now.AddDays(2), 4.5M),
			});

			var developer = new Developer("gosho", "deva", "0xffff", 3000m, Department.Production, new List<IProject>
			{
				new Project("Z# Programming language", DateTime.Now, "the language to end them all", State.Open),
				new Project("New Objective C", DateTime.Today, "OOP on a new level", State.Open),
			});

			var manager = new Manager("Gosho", "Peshov", "8227337ss", 250m, Department.Accounting, new List<IEmployee>
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

			var customer = new Customer("Custo", "Merov", "11223344", 5000m);
			Console.WriteLine(customer);
		}
	}
}