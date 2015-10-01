using System;

namespace _03.Exception_Handling
{
	class ExceptionMain
	{
		static void Main()
		{
			try
			{
				Person pesho = new Person("Pesho", "Peshev", 24);
				Person noName = new Person(string.Empty, "Goshev", 33);
				Person noLastName = new Person("Ivan", string.Empty, 35);
				Person negativeAge = new Person("Dragan", "Peshov", -30);
				Person tooOld = new Person("Gosho", "Ivanov", 150);
			}

			catch (ArgumentNullException ex)
			{
				Console.WriteLine($"Exception thrown: {ex.Message}");
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine($"Exception thrown: {ex.Message}");
			}

		}
	}
}
