using System;

namespace _2.Laptop_Shop
{
	class LaptopShopMain
	{
		 static void Main()
		{
			var lenovo = new Laptop("Thinkpad", "Lenovo");
			var asus = new Laptop("Asus", "P52F", "P6100", "Intel GMA 500", 500, "LCD", 2000, new Battery("Li-Ion", 4, 5000), 6,
				800);

			Console.WriteLine(lenovo);
			Console.WriteLine(asus);
		}
	}
}