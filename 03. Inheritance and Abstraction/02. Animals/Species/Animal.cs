using System;
using _02.Animals.Interfaces;

namespace _02.Animals.Species
{
	public abstract class Animal : ISoundProducible
	{
		protected const int PrintPadding = 8;
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
				this.name = value;
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
				this.age = value;
			}
		}

		public string Gender
		{
			get { return this.gender; }
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("gender", "Gender must not be empty.");
				}
				this.gender = value;
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
			return $"Species: {GetType().Name.PadRight(PrintPadding)} " +
			       $"Name: {name.PadRight(PrintPadding)} " +
			       $"Age: {age.ToString().PadRight(2)} " +
			       $"Gender: {gender}";
		}

		public abstract void ProduceSound();
	}
}