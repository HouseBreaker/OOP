using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using _02.Animals.Species;

namespace _02.Animals
{
	internal class AnimalsMain
	{
		private static void Main()
		{
			var animals = new List<Animal>
			{
				new Tomcat("Gosho", 10),
				new Kitten("Isabella", 6),
				new Dog("Rex", 15, "male"),
				new Dog("Sharo", 5, "male"),
				new Dog("Djoko", 8, "male"),
				new Frog("Croaky", 3, "female"),
				new Frog("Jenny", 3, "female"),
				new Cat("Bobo", 15, "male")
			};

			foreach (var animal in animals)
				Console.WriteLine(animal);

			Console.WriteLine();
			Console.WriteLine("Make some noise!");

			foreach (var animal in animals)
				animal.ProduceSound();

			Console.WriteLine();

			animals
				.OrderBy(p => p.GetType().Name)
				.Select(p => p.GetType().Name)
				.Distinct()
				.ToList()
				.ForEach(
					animal =>
						Console.WriteLine("Average age of the {0} {1:F0}",
							$"{animal}s:".ToLower().PadRight(10),
							animals.Where(p => p.GetType().Name == animal).Average(p => p.Age)));
		}
	}
}