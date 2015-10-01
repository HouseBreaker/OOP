using System;
using _02.Animals.Interfaces;

namespace _02.Animals.Species
{
	class Cat : Animal, ISoundProducible
	{
		public Cat(string name, int age, string gender) 
			: base(name, age, gender)
		{

		}

		public void ProduceSound()
		{
			Console.WriteLine($"{this.Name} says meow!");
		}
	}
}
