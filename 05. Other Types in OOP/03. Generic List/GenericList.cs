using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.Generic_List
{
	[Version(1, 2544)]
	public class GenericList<T> : IGenericList<T>, IEnumerable<T>
	{
		private const int DefaultCapacity = 16;

		private T[] internalArray;

		public GenericList()
		{
			internalArray = new T[DefaultCapacity];
		}

		public int Capacity => internalArray.Length;

		public int Count { get; private set; }

		public void Add(T element)
		{
			if (Count >= Capacity)
			{
				ResizeArray();
			}

			internalArray[Count] = element;
			Count++;
		}

		public void AddRange(params T[] items)
		{
			foreach (var item in items)
			{
				Add(item);
			}
		}

		public void Insert(int index, T item)
		{
			if (index == Count)
			{
				Add(item);
			}

			ValidateIndex(index);

			if (Count >= Capacity - 1)
			{
				ResizeArray();
			}

			for (int i = Count; i > index; i--)
			{
				internalArray[i] = internalArray[i - 1];
			}

			internalArray[index] = item;
			Count++;
		}

		public void Remove(T item)
		{
			int itemIndex = this.IndexOf(item);

			if (itemIndex != -1)
			{
				this.RemoveAt(itemIndex);
			}
		}

		public void RemoveAt(int index)
		{
			ValidateIndex(index);

			for (var i = index; i < Count; i++)
			{
				internalArray[i] = internalArray[i + 1];
			}

			Count--;
			internalArray[Count] = default(T);
		}

		public int IndexOf(T item)
		{
			for (int i = 0; i < Count; i++)
			{
				if (this[i].Equals(item))
				{
					return i;
				}
			}
			return -1;
		}

		public void Clear()
		{
			for (int i = 0; i < Count; i++)
			{
				this[i] = default(T);
			}

			Count = 0;
		}

		public bool Contains(T item)
		{
			return Enumerable.Contains(this, item);
		}

		public T this[int index]
		{
			get
			{
				ValidateIndex(index);
				return internalArray[index];
			}
			set
			{
				ValidateIndex(index);
				internalArray[index] = value;
			}
		}

		private void ResizeArray()
		{
			var temp = new T[internalArray.Length*2];

			Array.Copy(internalArray, temp, Count);

			internalArray = temp;
		}

		// Validation
		private void ValidateIndex(int index)
		{
			if (index >= Count || index < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range");
			}
		}

		// override methods and IEnumerable implementation
		public override string ToString()
		{
			return $"[{string.Join(", ", this)}]";
		}

		public T Max()
		{
			return this.ToArray().Max();
		}

		public T Min()
		{
			return this.ToArray().Min();
		}

		public IEnumerator<T> GetEnumerator()
		{
			for (int i = 0; i < Count; i++)
			{
				yield return this[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public string Version()
		{
			var versionNum = string.Empty;
			var type = typeof (GenericList<T>);
			var allAttributes = type.GetCustomAttributes(false);
			foreach (var attr in allAttributes)
			{
				var attribute = attr as VersionAttribute;
				if (attribute != null)
				{
					var version = attribute;
					versionNum = $"GenericList<T> version {version.Major}.{version.Minor}";
				}
			}

			return versionNum;
		}
	}
}