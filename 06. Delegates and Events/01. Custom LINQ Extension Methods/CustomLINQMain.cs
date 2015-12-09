using System;
using System.Linq;

namespace _01.Custom_LINQ_Extension_Methods
{
	class CustomLINQMain
	{
		static void Main()
		{
			var collection = Enumerable.Range(1, 10).ToList();
			Console.WriteLine("Initial list: [{0}]", string.Join(", ", collection));

			collection = collection.WhereNot(num => num%2 == 0).ToList();
			Console.WriteLine("Maximum from [{0}] => {1}", string.Join(", ", collection), collection.Max());
		}
	}
}