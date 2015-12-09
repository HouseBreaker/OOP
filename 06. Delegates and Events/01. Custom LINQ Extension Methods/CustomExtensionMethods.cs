using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Custom_LINQ_Extension_Methods
{
	public static class CustomExtensionMethods
	{
		public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
		{
			var result = new List<T>();

			foreach (var item in collection)
			{
				if (!predicate(item))
				{
					result.Add(item);
				}
			}

			return result;

			// or just: return collection.Where(item => !predicate(item));
		}

		public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> func)
			where TSelector : IComparable<TSelector>
		{
			var result = collection.Select(func).ToList();

			var max = result[0];
			for (var i = 1; i < result.Count; i++)
			{
				if (result[i].CompareTo(max) > 0)
				{
					max = result[i];
				}
			}
			return max;
		}
	}
}