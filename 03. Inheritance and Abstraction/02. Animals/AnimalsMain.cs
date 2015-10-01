using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using _02.Animals.Species;

namespace _02.Animals
{
	class AnimalsMain
	{
		static void Main()
		{
			Animal[] animalArray =
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

			foreach (var animal in animalArray)
			{
				Console.WriteLine(animal);
			}

			Console.WriteLine();

			List<string> selectedTypes = animalArray
				.Select(p => p.GetType().Name)	//Get distinct names
				.Distinct()						//Remove duplicates
				.ToList();

			selectedTypes.Sort();

			foreach (var x in selectedTypes)
			{
				Console.WriteLine("Average age of {0} - {1:F0}",
					x,
					animalArray
					.Where(p => p.GetType().Name == x)
					.Average(p => p.Age));
			}

			//look at this shitty huge linq expression you can do this whole thing in tho
			//animalArray.OrderBy(p => p.GetType().Name).Select(p => p.GetType().Name).Distinct().ToList().ForEach(x => Console.WriteLine("Average age of {0} - {1:F0}", x,animalArray.Where(p => p.GetType().Name == x).Average(p => p.Age))); 
		}
	}
}
