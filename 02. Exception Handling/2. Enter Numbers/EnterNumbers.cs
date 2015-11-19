using System;

namespace _2.Enter_Numbers
{
	internal class EnterNumbers
	{
		private static void Main()
		{
			int start = 1, end = 100;
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
						Console.Write($"   | valid! {tracker}/10\n");
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