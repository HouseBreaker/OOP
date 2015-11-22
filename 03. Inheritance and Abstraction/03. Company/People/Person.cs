using System;
using System.Text.RegularExpressions;

namespace _03.Company.People
{
	public abstract class Person
	{
		protected const int PrintPadding = 12;
		protected const string Tab = "   ";

		private string firstName, lastName, id;
		public string Name { get; }

		protected Person(string firstName, string lastName, string id)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Id = id;

			this.Name = this.FirstName + " " + this.LastName;
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
			var delimitedType = Regex.Replace(GetType().Name, @"([a-z])([A-Z])", "$1 $2");

			return $"{FirstName} {LastName} - {delimitedType}:"
			       + Environment.NewLine +
			       Tab + $"ID".PadRight(PrintPadding) + Id;
		}
	}
}