using System;

namespace _2.Enter_Numbers
{
	internal class EnterNumbers
	{
		private static void Main()
		{
			int start = 0, end = 100;
			ReadNumber(start, end);
		}

		private static void ReadNumber(int min, int max)
		{
			var tracker = 1;
			var prevNumber = min;

			while (tracker <= 10)
			{
				try
				{
					var currentNumber = int.Parse(Console.ReadLine());

					if (currentNumber < min || currentNumber > max)
					{
						throw new ArgumentOutOfRangeException("currentNumber");
					}
					if (currentNumber > prevNumber)
					{
						Console.WriteLine($"   | valid! {tracker}/10");
						prevNumber = currentNumber;
						tracker++;
					}
				}
				catch (ArgumentOutOfRangeException outtaRange)
				{
					Console.Error.WriteLine(outtaRange.Message);
				}
				catch (FormatException wrongFormat)
				{
					Console.Error.WriteLine(wrongFormat.Message);
				}
			}
		}
	}
}