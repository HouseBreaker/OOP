using System;

namespace _01.Persons
{
	class PersonsProblem
	{
		static void Main()
		{
			Person gosho = new Person("Gosho", 32);
			Person pesho = new Person("Pesho", 24, "pesho@abv.bg");

			Console.WriteLine(gosho);
			Console.WriteLine(pesho);
		}
	}
}