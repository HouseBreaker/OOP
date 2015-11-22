using System;
using System.Collections.Generic;
using _03.Company.Commodities;
using _03.Company.Enums;
using _03.Company.People.Employees;

namespace _03.Company
{
	internal class CompanyMain
	{
		private static void Main()
		{
			var manager = new Manager("Gosho", "Peshov", "8227337ss", 250, Department.Production, new List<Employee>()
			{
				new RegularEmployee("Ivo", "Peshov", "54321", 400, Department.Marketing),
				new SalesEmployee("Ivan", "Zvezdev", "12345", 500, new List<Sale>()
				{
					new Sale("toothpaste", DateTime.Today, 500)
				}),
			});

			Console.WriteLine(manager);
		}
	}
}