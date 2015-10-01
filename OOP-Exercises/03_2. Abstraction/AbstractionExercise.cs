using System;
using _03_2.Abstraction.Characters;

namespace _03_2.Abstraction
{
	class AbstractionExercise
	{
		static void Main()
		{
			Mage gosho = new Mage();

			Warrior emil = new Warrior();

			emil.Attack(gosho);


		}
	}
}
