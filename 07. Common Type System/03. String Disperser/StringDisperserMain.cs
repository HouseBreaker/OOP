using System;

namespace _03.String_Disperser
{
	class StringDisperserMain
	{
		static void Main()
		{
			StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");

			Console.WriteLine(string.Join(" ", stringDisperser));
		}
	}
}
