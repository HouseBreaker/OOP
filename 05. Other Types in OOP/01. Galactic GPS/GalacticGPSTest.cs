using System;

namespace _01.Galactic_GPS
{
	static class GalacticGPSTest
	{
		static void Main()
		{
			var home = new Location(18.037986, 28.870097, Planet.Earth);
			Console.WriteLine(home);
		}
	}
}
