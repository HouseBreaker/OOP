using System;

namespace _03.OOP_Inheritance_and_Abstraction___1
{
	class BookShop
	{
		static void Main()
		{
			Book book = new Book("Pod Igoto", "Ivan Vazov", 15.90m);
			Console.WriteLine(book);
			Console.WriteLine();

			GoldenEditionBook goldenbook = new GoldenEditionBook("Tutun", "Dimitar Dimov", 22.90m);
			Console.WriteLine(goldenbook);
		}
	}
}
