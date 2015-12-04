using System;
using _03.Generic_List;

namespace _04.Generic_List_Version
{
	class GenericListVersion
	{
		static void Main()
		{
			var list = new GenericList<string>();
			Console.WriteLine(list.Version());
		}
	}
}