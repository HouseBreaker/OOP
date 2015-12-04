using System;
using System.Linq;

namespace _03.Generic_List
{
	class GenericListMain
	{
		static void Main()
		{
			var intList = new GenericList<int>();

			intList.AddRange(Enumerable.Range(1, 30).ToArray());

			Console.WriteLine("Number of elements: {0}", intList.Count);
			Console.WriteLine(intList);

			Console.WriteLine($"List contains 7: {intList.Contains(7)}");
			Console.WriteLine($"Index of 12: {intList.IndexOf(12)}");

			Console.WriteLine();

			var stringList = new GenericList<string>
			{
				"C#",
				"Java",
				"PHP",
				"SQL"
			};

			Console.WriteLine($"Number of elements: {stringList.Count}");
			Console.WriteLine(stringList);

			Console.WriteLine($"List contains \"Java\": {stringList.Contains("Java")}");
		}
	}
}