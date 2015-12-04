namespace _03.Generic_List
{
	public interface IGenericList<T>
	{
		int Capacity { get; }

		int Count { get; }

		T this[int index] { get; set; }

		void Add(T item);

		void Insert(int index, T item);

		void Remove(T item);

		void RemoveAt(int index);

		void AddRange(params T[] items);

		void Clear();

		int IndexOf(T item);

		bool Contains(T item);
	}
}
