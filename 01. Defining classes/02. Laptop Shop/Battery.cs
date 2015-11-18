using System;
using System.Text;

namespace _2.Laptop_Shop
{
	internal class Battery
	{
		private string type;
		private int cells;
		private int capacity;

		public Battery(string type, int cells, int capacity)
		{
			this.Type = type;
			this.Cells = cells;
			this.Capacity = capacity;
		}

		public string Type
		{
			get { return type; }
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Type cannot be null or empty.");
				}
				type = value;
			}
		}

		public int Cells
		{
			get { return cells; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException(nameof(value), "Number of cells cannot be less than 0 cells");
				}
				cells = value;
			}
		}

		public int Capacity
		{
			get { return capacity; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException(nameof(value), "Capacity cannot be less than 0 mAh");
				}
				capacity = value;
			}
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append($"{type}, {cells}-cells, {capacity}mAh");
			return sb.ToString();
		}
	}
}