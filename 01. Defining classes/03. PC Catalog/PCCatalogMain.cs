using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace _03.PC_Catalog
{
	internal class PCCatalogMain
	{
		private static void Main()
		{
			Console.OutputEncoding = Encoding.UTF8;
			Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

			var asus = new Computer("Asus Prebuilt", new List<Component>()
			{
				new Component("CPU", "Phenom II x4", 206),
				new Component("RAM", "8GB 1600MHz", 60),
				new Component("Motherboard", "Asus something", 50),
				new Component("HDD", 80)
			});

			var sony = new Computer("Sony Prebuilt", new List<Component>()
			{
				new Component("CPU", "Phenom II x4", 206),
				new Component("RAM", "8GB 1600MHz", 60),
				new Component("Motherboard", "Asus something", 50),
				new Component("HDD", 80)
			});

			Console.WriteLine(asus);
		}
	}
}