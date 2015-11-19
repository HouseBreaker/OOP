using System;

namespace _1.Square_Root
{
	internal class SquareRoot
	{
		private static void Main()
		{
			try
			{
				var input = int.Parse(Console.ReadLine());
				Console.WriteLine($"Square root of {input} is {CalcSquareRoot(input)}");
			}
			catch (FormatException up)
			{
				Console.WriteLine($"Exception: {up.Message}");
			}
			finally
			{
				Console.WriteLine("Goodbye!");
			}
		}

		private static int CalcSquareRoot(int input)
		{
			return input*input;
		}
	}
}