using System;
using System.Collections.Generic;

namespace _02.Customer
{
	class CustomerMain
	{
		static void Main()
		{
			var customer1 = new Customer(
				"Gosho", "Ivanov", "Peshov",
				9302238338,
				"Tsarigradsko Shose 5",
				0886333333,
				"gosho@gmail.com",
				new List<Payment>
				{
					new Payment("Beans", 2.50m),
					new Payment("Toothpaste", 1.20m)
				},
				CustomerType.Regular);

			var customer2 = (Customer) customer1.Clone(); // using the old way to cast because checking for null is compile-time (ie. safer)

			customer2.Payments.Add(new Payment("Chewing gum", 0.90m)); // he's unequal to customer1 now

			customer2.FirstName = "Angel"; // he'll come first if you sort the list he's part of
			//customer2.Id = 1111111111; // he'll also come first if his ID comes first

			var customers = new List<Customer> {customer1, customer2};
			customers.Sort(); // when we sort the list, Angel goes first because his name is earlier in the alphabet

			Console.WriteLine(string.Join("\n\n", customers));
		}
	}
}