using System;

namespace _02.Animals.Species
{
	public abstract class Animal
	{
		private string name;
		private int age;
		private string gender;

		public string Name
		{
			get { return this.name; }
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("name", "Name must not be empty.");
				}
				name = value;
			}
		}

		public int Age
		{
			get { return age; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("age", "Age must be positive.");
				}
				age = value;
			}
		}

		public string Gender
		{
			get { return this.gender; }
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("name", "Name must not be empty.");
				}
				gender = value;
			}
		}

		protected Animal(string name, int age, string gender)
		{
			this.Name = name;
			this.Age = age;
			this.Gender = gender;
		}

		public override string ToString()
		{
			return string.Format($"Species: {GetType().Name.PadRight(6)} Name: {name.PadRight(8)} Age: {age.ToString().PadRight(2)} Gender: {gender}");
		}
	}
}
