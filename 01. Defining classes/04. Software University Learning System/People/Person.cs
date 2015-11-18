using System;
using System.Text;

namespace _04.Software_University_Learning_System.People
{
	public abstract class Person
	{
		protected const int Printpadding = 18;

		private string firstName;
		private string lastName;
		private int age;

		protected Person(string firstName, string lastName, int age)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
		}

		public string FirstName
		{
			get { return firstName; }
			set { firstName = CheckStr(ref value); }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = CheckStr(ref value); }
		}

		public int Age
		{
			get { return age; }
			set
			{
				if (age < 0)
					throw new ArgumentOutOfRangeException(nameof(value), "Age cannot be negative");

				age = value;
			}
		}

		protected string CheckStr(ref string value)
		{
			if (string.IsNullOrEmpty(value.Trim()))
			{
				throw new ArgumentException(nameof(value), $"{nameof(value)} cannot be blank.");
			}

			return value;
		}

		protected int CheckInt(ref int value)
		{
			if (value < 0)
				throw new ArgumentException(nameof(value), $"{nameof(value)} cannot be negative.");

			return value;
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine("Name".PadRight(Printpadding) + $"{FirstName} {LastName}");
			sb.AppendLine("Age".PadRight(Printpadding) + $"{Age}");
			return sb.ToString();
		}
	}
}