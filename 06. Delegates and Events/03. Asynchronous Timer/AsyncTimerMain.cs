using System;
using System.Runtime.Remoting.Channels;

namespace _03.Asynchronous_Timer
{
	class AsyncTimerMain
	{
		static void Main()
		{
			Action<int> generateRandomLetterOrChar = GenerateRandomLetter;

			const string message =
				"I'm running independly of the timer, so I show up before the timer is up. Anyway here's 111 random characters:";

			var timer = new AsyncTimer(generateRandomLetterOrChar, message.Length, 70);
			timer.Run();

			Console.WriteLine(message);
		}

		private static void GenerateRandomLetter(int seed)
		{
			const int minReadableChar = 33, maxReadableChar = 126;
			var rand = new Random(seed);
			Console.Write((char) rand.Next(minReadableChar, maxReadableChar));
		}
	}
}