using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace _2.Laptop_Shop
{
	class LaptopShopMain
	{
		 static void Main()
		{
			Console.OutputEncoding = Encoding.UTF8;
			Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

			var lenovo = new Laptop("Lenovo", "Thinkpad");
			var asus = new Laptop("Asus", "P52F", "P6100", "Intel GMA 500", 500, "LCD", 2000, new Battery("Li-Ion", 4, 5000), 6,
				800);

			Console.WriteLine(lenovo);
			Console.WriteLine(asus);
		}
	}
}