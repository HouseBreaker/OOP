using System;

namespace _03.Company.People
{
	public abstract class Person
	{
		protected const int PrintPadding = 12;
		protected const string tab = "   ";

		private string firstName, lastName, id;

		protected Person(string firstName, string lastName, string id)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Id = id;
		}

		public string FirstName
		{
			get { return firstName; }
			protected set { firstName = ValidateStr(value, "First name"); }
		}

		public string LastName
		{
			get { return lastName; }
			protected set { lastName = ValidateStr(value, "Last name"); }
		}

		public string Id
		{
			get { return id; }
			protected set { id = ValidateStr(value, "ID"); }
		}

		protected static string ValidateStr(string value, string param)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentNullException(param, $"{param} cannot be empty.");
			}
			return value;
		}

		protected static decimal ValidateNum(decimal value, string param)
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException(param, $"{param} cannot be negative.");
			}
			return value;
		}

		public override string ToString()
		{
			return $"{FirstName} {LastName} - {GetType().Name}:"
			       + Environment.NewLine +
			       tab + $"ID".PadRight(PrintPadding) + Id;
		}
	}
}