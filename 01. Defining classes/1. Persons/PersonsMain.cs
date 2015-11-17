using System;

namespace _01.Persons
{
	class PersonsMain
	{
		static void Main()
		{
			var gosho = new Person("Gosho", 32);
			var pesho = new Person("Pesho", 24, "pesho@abv.bg");
			var ivan = new Person("Ivan", 32, null);

			Console.WriteLine(gosho);
			Console.WriteLine(pesho);
			Console.WriteLine(ivan);
		}
	}
}